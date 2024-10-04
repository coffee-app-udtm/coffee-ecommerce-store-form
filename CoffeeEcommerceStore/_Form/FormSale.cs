using CoffeeLibrary.Model;
using CoffeeLibrary.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using UCProduct;
using CoffeeLibrary;
using System.Windows.Forms.VisualStyles;

namespace CoffeeEcommerceStore
{
    public partial class FormSale : System.Windows.Forms.Form
    {
        ProductRequest productRequest = new ProductRequest();
        CategoryRequest categoryRequest = new CategoryRequest();
        CartRequest cartRequest = new CartRequest();
        UserRequest userRequest = new UserRequest();
        OrderRequest orderRequest = new OrderRequest();

        List<Product> products = new List<Product>();
        List<Cart> orderItems = new List<Cart>();

        List<Cart> orderItemsForBill = null;
        Order orderResult = null;

        Product selectedProduct = null;
        User customer = null;


        string userId = "store_1"; // get from properties setting

        public FormSale()
        {
            InitializeComponent();

            this.Load += FormSale_Load;
            this.button_search.Click += Button_search_Click;
            this.button_add_order_item.Click += Button_add_order_item_Click;
            this.button_remove_order_item.Click += Button_remove_order_item_Click;
            this.button_find_customer.Click += Button_find_customer_Click;
            this.button_place_order.Click += Button_place_order_Click;

            this.printDocument_order.PrintPage += PrintDocument_order_PrintPage;
            this.printDocument_order.EndPrint += PrintDocument_order_EndPrint; ;

            ResetAfterAddedToCart();
        }

        private void PrintDocument_order_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //orderItemsForBill = new List<Cart>();
            //orderResult = null;

            ResetAfterPlacedOrder();

            button_place_order.Enabled = true;
            button_place_order.Text = "Đặt hàng";
        }


        // PRINT ORDER BILL
        private void PrintDocument_order_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Font headerFont = new Font("Arial", 12, FontStyle.Regular);
            Font titleFont = new Font("Arial", 24, FontStyle.Bold);


            string storeName = orderResult.store_name ?? "Unknown store name";
            string orderId = "Số Bill: " + orderResult.id;
            string customerName = customer != null ? "Khách hàng: " + orderResult.user_name : "Khách hàng: Unknown";
            string cashier = "Thu ngân: SM";
            string orderTime = "Thời gian: " + orderResult.order_date.ToString("dd/MM/yyyy HH:mm:ss");

            // Danh sách sản phẩm
            
            int lineWidth = e.MarginBounds.Width;

            // Logo và tiêu đề cửa hàng
            Image image = Properties.Resources.coffee_image_sample;  // Giả sử logo cửa hàng có trong resources
            e.Graphics.DrawImage(image, 350, 10, 100, 100);  // Căn giữa logo

            e.Graphics.DrawString(storeName, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(300, 120)); // Căn giữa tên cửa hàng

            // Thông tin đơn hàng
            e.Graphics.DrawString(orderId, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString(customerName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString(cashier, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString(orderTime, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 220));

            // Vẽ danh sách sản phẩm
            e.Graphics.DrawString(new string('-', 180), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 240));
            
            e.Graphics.DrawString("Sản phẩm", headerFont, Brushes.Black, new Point(30, 260));
            e.Graphics.DrawString("Số lượng", headerFont, Brushes.Black, new Point(280, 260));
            e.Graphics.DrawString("Đơn giá", headerFont, Brushes.Black, new Point(410, 260));
            e.Graphics.DrawString("Tổng tiền", headerFont, Brushes.Black, new Point(700, 260));

            e.Graphics.DrawString(new string('-', 180), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 280));

            // Bắt đầu vẽ từng sản phẩm trong danh sách
            int yPosition = 300;
            foreach (var item in orderItemsForBill)
            {

                e.Graphics.DrawString(item.product_name, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, yPosition));
                e.Graphics.DrawString(item.quantity.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(280, yPosition));
                e.Graphics.DrawString(Util.FormatVNCurrency(item.product_price), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(410, yPosition));
                e.Graphics.DrawString(Util.FormatVNCurrency(item.order_item_price), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, yPosition));


                yPosition += 30;  
            }

            // Vẽ dòng tổng tiền
            e.Graphics.DrawString(new string('-', 180), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 280));
            yPosition += 20;  // Dịch xuống dòng tiếp theo
            e.Graphics.DrawString("Tổng tiền thanh toán: " + String.Format("{0:N0} đ", orderItemsForBill.Sum(p => p.order_item_price)), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, yPosition));
        }

        private async void Button_place_order_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn tạo đơn hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // ***** fake store id
            int storeId = 1; // get from properties setting

            if (dialogResult == DialogResult.Yes)
            {
                button_place_order.Enabled = false;
                button_place_order.Text = "Đang xử lý...";

                CreateOrder createOrderInfo = new CreateOrder
                {
                    order_id = Util.GenerateOrderId(),
                    user_id = customer != null ? customer.id : userId,
                    total_payment = (int)orderItems.Sum(item => item.order_item_price),
                    payment_method = "Cash",
                    order_type = "offline",
                    order_note = "Unknown",
                    order_status = "Hoàn thành",
                    shipping_cost = 0,
                    receiver_name = customer != null ? customer.user_name : "Unknown",
                    phone_number = "Unknown",
                    address = "Unknown",
                    store_id = storeId,
                    order_items = orderItems
                };

                orderItemsForBill = orderItems;

                Order orderResponse = await orderRequest.CreateOrderAsync(createOrderInfo);

                if (orderResponse != null)
                {
                    orderResult = orderResponse;
                    

                    MessageBox.Show("Tạo đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //ResetAfterPlacedOrder();

                    //button_place_order.Enabled = true;
                    //button_place_order.Text = "Đặt hàng";

                    printPreviewDialog_order.Document = printDocument_order;
                    printPreviewDialog_order.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tạo hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void Button_find_customer_Click(object sender, EventArgs e)
        {
            string status = button_find_customer.Text;

            if (status == "Gỡ")
            {

                DialogResult dialogResult = MessageBox.Show("Bạn có muốn gỡ khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    customer = null;
                    textBox_email_or_phone.Text = "";
                    textBox_email_or_phone.Enabled = true;

                    button_find_customer.Text = "Tìm";
                    button_find_customer.BackColor = Color.White;
                    button_find_customer.ForeColor = Color.Black;

                    label_customer_info.Text = "Unknown";

                    userId = "store_1"; // get from properties setting
                }

                return;
            }

            try
            {
                string value = textBox_email_or_phone.Text.Trim();

                if (string.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Vui lòng nhập email hoặc số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                button_find_customer.Enabled = false;
                button_find_customer.Text = "Đang tìm...";

                User customerFound = await userRequest.GetUserByEmailOrPhoneNumberAsync(value);

                if (customerFound == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    button_find_customer.Enabled = true;
                    button_find_customer.Text = "Tìm";
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Tìm thấy khách hàng: " + customerFound.user_name + ". Bạn có muốn chọn khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    customer = customerFound;
                    userId = customer.id;

                    textBox_email_or_phone.Enabled = false;
                    button_find_customer.Text = "Gỡ";
                    button_find_customer.BackColor = Color.Red;
                    button_find_customer.ForeColor = Color.White;
                    RenderCustomerInfo();
                }

            }
            catch (Exception ex)
            {
                button_find_customer.Enabled = true;
                button_find_customer.Text = "Tìm";

                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Button_remove_order_item_Click(object sender, EventArgs e)
        {
            if (listBox_order_items.SelectedIndex > -1)
            {
                try
                {
                    Cart selectedCart = (Cart)listBox_order_items.SelectedItem;

                    bool result = await cartRequest.DeleteCartAsync(selectedCart.id);

                    if (result)
                    {
                        orderItems.Remove(selectedCart);

                        listBox_order_items.DataSource = null;
                        listBox_order_items.DataSource = orderItems;

                        listBox_order_items.DisplayMember = "display_info";
                        listBox_order_items.ValueMember = "id";

                        RenderTotalPayment();

                        orderItemsForBill = orderItems;
                    }
                    else
                    {
                        MessageBox.Show(Text, "Xóa sản phẩm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void Button_add_order_item_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDown_quantity.Value;
            

            int? selectedSizeId = null;
            foreach (RadioButton radioButton in panel_sizes.Controls)
            {
                if (radioButton.Checked)
                {
                    ProductSize selectedSize = (ProductSize)radioButton.Tag;
                    selectedSizeId = selectedSize.size_id;
                    break;
                }
            }

            List<int> selectedToppingIds = new List<int>();
            foreach (ProductTopping topping in checkedListBox_toppings.CheckedItems)
            {
                selectedToppingIds.Add(topping.id);
            }

            try
            {
                button_add_order_item.Enabled = false;
                button_add_order_item.Text = "Đang thêm...";

                bool result = await cartRequest.AddToCartAsync(selectedProduct.id, userId, quantity, selectedSizeId, selectedToppingIds);

                if (result)
                {
                    // Render listbox cart
                    RenderOrderItems();
                }

                else
                {
                    MessageBox.Show("Thêm vào giỏ hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                button_add_order_item.Enabled = true;
                button_add_order_item.Text = "Thêm vào";
            }
            catch (Exception ex)
            {
                button_add_order_item.Enabled = true;
                button_add_order_item.Text = "Thêm vào";

                MessageBox.Show(ex.Message);
            }


        }

        private void Button_search_Click(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private async void FormSale_Load(object sender, EventArgs e)
        {
            try {
                await LoadProductsAsync();
                await RenderComboboxCategory();

                RenderOrderItems();

                this.comboBox_category.SelectedIndexChanged += ComboBox_category_SelectedIndexChanged;

            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ComboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private async Task LoadProductsAsync()
        {

            // Get all product first
            products = await productRequest.GetProductsAsync(null, 0);


            flowLayoutPanel_products.Controls.Clear();

            // Tạo các card sản phẩm và thêm vào FlowLayoutPanel
            foreach (var product in products)
            {
                UCProductCard card = new UCProductCard
                {
                    product = product
                };

                card.selectProductEvent += SelectProductHandler;

                flowLayoutPanel_products.Controls.Add(card);
            }
        }

        private void ResetAfterAddedToCart()
        {
            selectedProduct = null;
            numericUpDown_quantity.Value = 1;
            panel_sizes.Controls.Clear();
            checkedListBox_toppings.Items.Clear();
        }

        private void ResetAfterPlacedOrder()
        {
            customer = null;
            orderItems.Clear();

            listBox_order_items.DataSource = null;
            listBox_order_items.Items.Clear();

            selectedProduct = null;

            textBox_email_or_phone.Text = "";
            textBox_email_or_phone.Enabled = true;

            button_find_customer.Text = "Tìm";
            button_find_customer.BackColor = Color.White;
            button_find_customer.ForeColor = Color.Black;


            RenderTotalPayment();
            RenderCustomerInfo();
        }

        private void FilterProducts()
        {
            string searchValue = textBox_search.Text.Trim();
            int selectedCategoryId = comboBox_category.SelectedValue != null ? (int)comboBox_category.SelectedValue : 0;

            List<Product> filteredProducts = products;

            if (!string.IsNullOrEmpty(searchValue))
            {
                filteredProducts = filteredProducts
                    .Where(product => product.name.ToLower().Contains(searchValue.ToLower()))
                    .ToList();
            }

            if (selectedCategoryId > 0)
            {
                filteredProducts = filteredProducts
                    .Where(product => product.category_id == selectedCategoryId)
                    .ToList();
            }

            flowLayoutPanel_products.Controls.Clear();

            // Tạo các card sản phẩm và thêm vào FlowLayoutPanel
            foreach (var product in filteredProducts)
            {
                UCProductCard card = new UCProductCard
                {
                    product = product
                };

                card.selectProductEvent += SelectProductHandler;

                flowLayoutPanel_products.Controls.Add(card);
            }
        }

        private void SelectProductHandler(object sender, Product product)
        {
            selectedProduct = product;

            RenderSelectedProduct(product);

            RenderProductSizes(product.id);
            RenderProductToppings(product.id);
        }


        // RENDER
        private void RenderSelectedProduct(Product product)
        {
            // Hiển thị thông tin sản phẩm đã chọn
            label_selected_product_name.Text = product.name;
            label_selected_product_price.Text = Util.FormatVNCurrency(product.price);
            pictureBox_selected_product_image.ImageLocation = product.image;
        }

        private async void RenderProductSizes(int productId)
        {
            try
            {
                List<ProductSize> productSizes = await productRequest.GetProductSizesAsync(productId);

                panel_sizes.Controls.Clear();
                int yPosition = 10;
                bool isFirst = true; 


                foreach (var productSize in productSizes)
                {
                    RadioButton radioButton = new RadioButton();

                   
                    radioButton.Text = productSize.size_name + "(+ " + Util.FormatVNCurrency(productSize.size_price) + ")";  // Tên kích cỡ (ví dụ: Nhỏ, Vừa, Lớn)
                    radioButton.Tag = productSize;            // Lưu object ProductSize vào Tag để truy xuất khi cần
                    
                    radioButton.Location = new Point(10, yPosition); // Vị trí của RadioButton trong panel
                    radioButton.AutoSize = true;             // Đảm bảo kích thước RadioButton tự động điều chỉnh theo nội dung


                    // Check phần tử đầu tiên
                    if (isFirst)
                    {
                        radioButton.Checked = true;
                        isFirst = false; 
                    }

                    panel_sizes.Controls.Add(radioButton);

                    yPosition += radioButton.Height + 10;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void RenderProductToppings(int productId)
        {
            try
            {
                List<ProductTopping> productToppings = await productRequest.GetProductToppingsAsync(productId);

                checkedListBox_toppings.DataSource = productToppings;
                checkedListBox_toppings.DisplayMember = "display_info";  // Hiển thị tên topping và giá
                checkedListBox_toppings.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void RenderOrderItems()
        {
            try
            {
                orderItems = await cartRequest.GetCartsAsync(userId);
                orderItemsForBill = orderItems;

                listBox_order_items.DataSource = null;
                listBox_order_items.DataSource = orderItems;

                listBox_order_items.DisplayMember = "display_info";
                listBox_order_items.ValueMember = "id";

                RenderTotalPayment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderTotalPayment()
        {
            if (orderItems.Count > 0)
            {
                int totalPayment = (int)orderItems.Sum(item => item.order_item_price);
                label_total_payment.Text = Util.FormatVNCurrency(totalPayment);
            }
            else
            {
                label_total_payment.Text = "0 đ";
            }
        }

        private void RenderCustomerInfo()
        {
            if (customer != null)
            {
                label_customer_info.Text = customer.user_name;
            }
            else
            {
                label_customer_info.Text = "Unknown";
            }
        }

        private async Task RenderComboboxCategory()
        {
            comboBox_category.Items.Clear();
            

            List<Category> categories = await categoryRequest.GetCategoriesAsync();

           categories.Insert(0, new Category
           {
               id = 0,
               category_name = "Tất cả"
           });



            comboBox_category.DataSource = categories;
            comboBox_category.DisplayMember = "category_name";
            comboBox_category.ValueMember = "id";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

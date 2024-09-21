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

namespace CoffeeEcommerceStore
{
    public partial class FormSale : Form
    {
        ProductRequest productRequest = new ProductRequest();
        CategoryRequest categoryRequest = new CategoryRequest();
        List<Product> products = new List<Product>();

        public FormSale()
        {
            InitializeComponent();

            this.Load += FormSale_Load;
            this.button_search.Click += Button_search_Click;
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
    }
}

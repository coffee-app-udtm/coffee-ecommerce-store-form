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
            filterProducts();
        }

        private async void FormSale_Load(object sender, EventArgs e)
        {
            try {
                await loadProductsAsync();
                await renderComboboxCategory();

                this.comboBox_category.SelectedIndexChanged += ComboBox_category_SelectedIndexChanged;

            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ComboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterProducts();
        }

        private async Task loadProductsAsync()
        {

            // Get all product first
            products = await productRequest.getProductsAsync(null, 0);


            flowLayoutPanel_products.Controls.Clear();

            // Tạo các card sản phẩm và thêm vào FlowLayoutPanel
            foreach (var product in products)
            {
                UCProductCard card = new UCProductCard
                {
                    product = product
                };

                card.selectProductEvent += selectProductHandler;

                flowLayoutPanel_products.Controls.Add(card);
            }
        }

        private void filterProducts()
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

                card.selectProductEvent += selectProductHandler;

                flowLayoutPanel_products.Controls.Add(card);
            }
        }


        private void selectProductHandler(object sender, Product product)
        {
            renderSelectedProduct(product);
        }


        // RENDER
        private void renderSelectedProduct(Product product)
        {
            // Hiển thị thông tin sản phẩm đã chọn
            label_selected_product_name.Text = product.name;
            label_selected_product_price.Text = Util.formatVNCurrency(product.price);
            pictureBox_selected_product_image.ImageLocation = product.image;
        }

        private async Task renderComboboxCategory()
        {
            comboBox_category.Items.Clear();
            

            List<Category> categories = await categoryRequest.getCategoriesAsync();

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

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

namespace CoffeeEcommerceStore
{
    public partial class FormSale : Form
    {
        ProductRequest productRequest = new ProductRequest();

        public FormSale()
        {
            InitializeComponent();

            this.Load += FormSale_Load;
        }

        private async void FormSale_Load(object sender, EventArgs e)
        {
            try {
                await loadProductsAsync();
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async Task loadProductsAsync()
        {
            
            List<Product> products = await productRequest.getProductsAsync(null, 0);

            flowLayoutPanel_products.Controls.Clear();

            // Tạo các card sản phẩm và thêm vào FlowLayoutPanel
            foreach (var product in products)
            {
                UCProductCard card = new UCProductCard
                {
                    product = product
                };

                //card.selectProductEvent += selectProductEvent;

                flowLayoutPanel_products.Controls.Add(card);
            }
        }
    }
}

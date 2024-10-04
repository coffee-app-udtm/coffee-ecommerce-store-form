using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MODEL = CoffeeLibrary.Model;
using CoffeeLibrary.Request;

namespace CoffeeEcommerceStore._Form.Order
{
    public partial class FormOrderDetail : Form
    {

        public FormOrderDetail(string orderId)
        {
            InitializeComponent();

            RenderDetail(orderId);
        }

        private async void RenderDetail(string orderId)
        {
            try
            {
                OrderRequest orderRequest = new OrderRequest();
                MODEL.Order order = await orderRequest.GetOrderAsync(orderId);
                
                if (order == null)
                {
                    MessageBox.Show("Order not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (order == null)
                {
                    MessageBox.Show("Order not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ucOrderDetail1.Init(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
using FireSharp.Config;
using FireSharp.Interfaces;
using CoffeeLibrary.Model;
using FireSharp.Response;

namespace CoffeeEcommerceStore._Form.Order
{
    public partial class FormOrderDetail : Form
    {
        public IFirebaseConfig firebaseconfig = new FirebaseConfig
        {
            AuthSecret = "7pxmzjhkrfpg5tm6mpt5qbqtbwt5d6ytnlo8jjgv",
            BasePath = "https://ecommerce-app-83f6e-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

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

                // Update order status on firebase
                ucOrderDetail1.updateOrderStatusEvent += async (object sender, MODEL.Order updatedOrder) =>
                {
                    try
                    {
                        IFirebaseClient firebaseClient = new FireSharp.FirebaseClient(firebaseconfig);

                        OrderOnlineStatus statusUpdate = new OrderOnlineStatus
                        {
                            status = updatedOrder.order_status,
                            time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        };

                        //Update to firebase
                       FirebaseResponse firebaseResponse = await firebaseClient.UpdateAsync($"orders/{order.id}/statuses/{updatedOrder.order_status}", statusUpdate);

                        if (firebaseResponse.StatusCode != System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("Update order status failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

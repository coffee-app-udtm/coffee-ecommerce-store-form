using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeLibrary;
using CoffeeLibrary.Request;
using MODEL = CoffeeLibrary.Model;

namespace CoffeeEcommerceStore._Form.Order
{ 
    public partial class FormOrder : Form
    {
        OrderRequest orderRequest = new OrderRequest();
        List<MODEL.Order> orders = new List<MODEL.Order>();


        public FormOrder()
        {
            InitializeComponent();

            this.Load += FormOrder_Load;
            this.dataGridView_orders.CellClick += DataGridView_orders_CellClick;
        }

        private void DataGridView_orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView_orders.Rows.Count)
            {
                return;
            }

            DataGridViewRow row = dataGridView_orders.Rows[e.RowIndex];
            string orderId = row.Cells["id"].Value.ToString();
            

            // Show order detail form
            FormOrderDetail formOrderDetail = new FormOrderDetail(orderId);
            formOrderDetail.Owner = this;
            formOrderDetail.ShowDialog();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            RenderOrders();
        }

        private async void RenderOrders()
        {
            try
            {
                List<MODEL.Order> orders = await orderRequest.GetOrdersAsync();

                if (orders == null)
                {
                    MessageBox.Show("No orders found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dataGridView_orders.Rows.Clear();

                // **** Check if admin -> show all orders

                // **** Check if store owner -> show orders at store
                int storeId = 1;

                orders = orders.Where(o => o.store_id == storeId).OrderByDescending(o => o.order_date).ToList();

                if (orders.Count == 0)
                {
                    MessageBox.Show("No orders at store");
                    return;
                }

                if (dataGridView_orders.Columns.Count == 0)
                {
                    dataGridView_orders.Columns.Add("id", "Mã đơn hàng");
                    dataGridView_orders.Columns.Add("order_date", "Ngày đặt");
                    dataGridView_orders.Columns.Add("total_payment", "Tổng tiền");
                    dataGridView_orders.Columns.Add("order_status", "Trạng thái");
                    dataGridView_orders.Columns.Add("store_id", "Cửa hàng");
                }

                // Render to datagridview
                foreach (MODEL.Order order in orders)
                {
                    int index = dataGridView_orders.Rows.Add();
                    DataGridViewRow row = dataGridView_orders.Rows[index];

                    row.Cells["id"].Value = order.id;
                    row.Cells["order_date"].Value = order.order_date;
                    row.Cells["total_payment"].Value = Util.FormatVNCurrency(order.total_payment);
                    row.Cells["order_status"].Value = order.order_status;
                    row.Cells["store_id"].Value = order.store_id;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

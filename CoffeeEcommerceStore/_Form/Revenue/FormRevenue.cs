using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeEcommerceStore._Form.Revenue
{
    public partial class FormRevenue : Form
    {
        public FormRevenue()
        {
            InitializeComponent();

            // Get store id from settings
            int storeId = Properties.Settings.Default.store_id;
            string accountType = Properties.Settings.Default.account_type;

            this.ucRevenueList1.RenderStoreRevenue(storeId, accountType);
        }
    }
}

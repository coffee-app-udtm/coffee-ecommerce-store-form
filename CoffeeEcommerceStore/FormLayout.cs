using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeEcommerceStore
{
    public partial class FormLayout : Form
    {
        public FormLayout()
        {
            InitializeComponent();

            loadForm(new FormDashboard());
        }

        public void loadForm(object form)
        {
            if (this.panel_main.Controls.Count > 0)
            {
                this.panel_main.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(f);
            this.panel_main.Tag = f;
            f.Show();
        }


        private void button_nav_dashboard_Click(object sender, EventArgs e)
        {
            loadForm(new FormDashboard());
        }

        private void button_nav_product_Click(object sender, EventArgs e)
        {
            loadForm(new FormProduct());
        }
    }
}

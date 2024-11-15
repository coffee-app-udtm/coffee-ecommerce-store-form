using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoffeeEcommerceStore._Form.Product;
using CoffeeEcommerceStore._Form.Order;
using CoffeeEcommerceStore._Form.Revenue;
using CoffeeEcommerceStore._Form;

namespace CoffeeEcommerceStore
{

    public partial class FormLayout : System.Windows.Forms.Form
    {
        private List<Button> navButtons;
        public FormLayout()
        {
            InitializeComponent();

            // Thiết lập form toàn màn hình
            this.WindowState = FormWindowState.Maximized;  // Phóng to form
            this.TopMost = true;                           // Đặt form luôn trên các cửa sổ khác

            // 
            string currentUserName = Properties.Settings.Default.store_name;

            // Xử lý thêm ... nếu tên quá dài
            if (currentUserName.Length > 10)
            {
                currentUserName = currentUserName.Substring(0, 10) + "...";
            }

            this.button_current_user.Text = " " + currentUserName;

            initNavButtons();
            setActiveButton(button_nav_dashboard);
            loadForm(new FormSale());

            this.button_logout.Click += button_logout_Click;
            this.FormClosing += FormLayout_FormClosing;
        }

        private void FormLayout_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?",
                                          "Xác nhận thoát",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Nếu người dùng chọn "No", hủy việc đóng form
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất không?", "Logout", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                // Clear settings
                Properties.Settings.Default.store_id = 0;
                Properties.Settings.Default.store_name = "";
                Properties.Settings.Default.account_type = "";

                Properties.Settings.Default.Save();


                this.Hide();

                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
        }

        private void initNavButtons()
        {
            navButtons = new List<Button>();

            navButtons.Add(button_nav_dashboard);
            navButtons.Add(button_nav_product);
            navButtons.Add(button_nav_order);
            navButtons.Add(button_nav_revenue);

            foreach (var btn in navButtons)
            {
                btn.Click += button_nav_Click;
            }
        }

        private void setActiveButton(Button activeButton)
        {
            // Reset all buttons to default color
            foreach (var btn in navButtons)
            {
                btn.ForeColor = Color.Black; // Default color
            }

            activeButton.ForeColor = Color.FromArgb(255, 161, 108);
        }

        private void button_nav_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            setActiveButton(clickedButton);

            handleNavigateForm(clickedButton);
        }

        // Handle navigation form
        private void handleNavigateForm(Button clickedButton)
        {
            switch (clickedButton.Name)
            {
                case "button_nav_dashboard":
                    this.Text = "Dashboard";
                    loadForm(new FormSale());
                    break;
                case "button_nav_product":
                    this.Text = "Sản phẩm";
                    loadForm(new FormProduct());
                    break;
                case "button_nav_order":
                    this.Text = "Đơn hàng";
                    loadForm(new FormOrder());
                    break;
                case "button_nav_revenue":
                    this.Text = "Doanh thu";
                    loadForm(new FormRevenue());
                    break;
                default:
                    break;
            }
        }

        public void loadForm(object form)
        {
            if (this.panel_main.Controls.Count > 0)
            {
                this.panel_main.Controls.RemoveAt(0);
            }
            System.Windows.Forms.Form f = form as System.Windows.Forms.Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(f);
            this.panel_main.Tag = f;
            f.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using CoffeeLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCLogin;

namespace CoffeeEcommerceStore._Form
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            ucLoginStore1.LoginSuccessfulEvent += OnLoginSuccessful;
        }

        private void OnLoginSuccessful(object sender, StoreLogin e)
        {
            // Handle the login data here
            int storeId = e.id;
            string storeName = e.store_name;

            // Set to properties
            Properties.Settings.Default.store_id = storeId;
            Properties.Settings.Default.store_name = storeName;

            // Save the properties
            Properties.Settings.Default.Save();

            MessageBox.Show($"Đăng nhập thành công vào {storeName} (ID: {storeId})");

            // Close the login form
            this.Hide();

            // Show the main form
            FormLayout formLayout = new FormLayout();
            formLayout.Show();
        }
    }
}

﻿using System;
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

namespace CoffeeEcommerceStore
{

    public partial class FormLayout : System.Windows.Forms.Form
    {
        private List<Button> navButtons;
        public FormLayout()
        {
            InitializeComponent();

            initNavButtons();
            setActiveButton(button_nav_dashboard);
            loadForm(new FormSale());
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
                    loadForm(new FormSale());
                    break;
                case "button_nav_product":
                    loadForm(new FormProduct());
                    break;
                case "button_nav_order":
                    loadForm(new FormOrder());
                    break;
                case "button_nav_revenue":
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

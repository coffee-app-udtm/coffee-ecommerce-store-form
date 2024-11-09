﻿using CoffeeEcommerceStore._Form.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeEcommerceStore._Form.Size
{
    public partial class FormSize : Form
    {
        public FormSize()
        {
            InitializeComponent();
            this.button_back_product.Click += Button_back_product_Click;

            ucSizeList1.HideActionButtons();
        }

        private void Button_back_product_Click(object sender, EventArgs e)
        {

            FormLayout parentFormLayout = this.ParentForm as FormLayout;

            if (parentFormLayout != null)
            {
                parentFormLayout.loadForm(new FormProduct());
            }
        }
    }
}

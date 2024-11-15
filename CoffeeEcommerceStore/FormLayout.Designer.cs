﻿namespace CoffeeEcommerceStore
{
    partial class FormLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLayout));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_current_user = new System.Windows.Forms.Button();
            this.button_nav_revenue = new System.Windows.Forms.Button();
            this.button_nav_order = new System.Windows.Forms.Button();
            this.button_nav_product = new System.Windows.Forms.Button();
            this.button_nav_dashboard = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_main, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1158, 576);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button_logout);
            this.panel1.Controls.Add(this.button_current_user);
            this.panel1.Controls.Add(this.button_nav_revenue);
            this.panel1.Controls.Add(this.button_nav_order);
            this.panel1.Controls.Add(this.button_nav_product);
            this.panel1.Controls.Add(this.button_nav_dashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 570);
            this.panel1.TabIndex = 1;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(176, 3);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(979, 570);
            this.panel_main.TabIndex = 2;
            // 
            // button_logout
            // 
            this.button_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_logout.ForeColor = System.Drawing.Color.LightCoral;
            this.button_logout.Image = global::CoffeeEcommerceStore.Properties.Resources.icons8_logout_24;
            this.button_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_logout.Location = new System.Drawing.Point(25, 488);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(162, 60);
            this.button_logout.TabIndex = 1;
            this.button_logout.Text = "Đăng xuất";
            this.button_logout.UseVisualStyleBackColor = true;
            // 
            // button_current_user
            // 
            this.button_current_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_current_user.AutoSize = true;
            this.button_current_user.FlatAppearance.BorderSize = 0;
            this.button_current_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_current_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_current_user.Image = global::CoffeeEcommerceStore.Properties.Resources.icons8_test_account_24;
            this.button_current_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_current_user.Location = new System.Drawing.Point(25, 422);
            this.button_current_user.Name = "button_current_user";
            this.button_current_user.Size = new System.Drawing.Size(162, 60);
            this.button_current_user.TabIndex = 1;
            this.button_current_user.UseVisualStyleBackColor = true;
            // 
            // button_nav_revenue
            // 
            this.button_nav_revenue.FlatAppearance.BorderSize = 0;
            this.button_nav_revenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nav_revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_nav_revenue.Image = global::CoffeeEcommerceStore.Properties.Resources.icons8_dollar_coin_24;
            this.button_nav_revenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nav_revenue.Location = new System.Drawing.Point(25, 235);
            this.button_nav_revenue.Name = "button_nav_revenue";
            this.button_nav_revenue.Size = new System.Drawing.Size(162, 60);
            this.button_nav_revenue.TabIndex = 1;
            this.button_nav_revenue.Text = "Doanh thu";
            this.button_nav_revenue.UseVisualStyleBackColor = true;
            // 
            // button_nav_order
            // 
            this.button_nav_order.FlatAppearance.BorderSize = 0;
            this.button_nav_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nav_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_nav_order.Image = global::CoffeeEcommerceStore.Properties.Resources.icons8_sell_24;
            this.button_nav_order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nav_order.Location = new System.Drawing.Point(25, 169);
            this.button_nav_order.Name = "button_nav_order";
            this.button_nav_order.Size = new System.Drawing.Size(162, 60);
            this.button_nav_order.TabIndex = 1;
            this.button_nav_order.Text = "Đơn hàng";
            this.button_nav_order.UseVisualStyleBackColor = true;
            // 
            // button_nav_product
            // 
            this.button_nav_product.FlatAppearance.BorderSize = 0;
            this.button_nav_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nav_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_nav_product.Image = global::CoffeeEcommerceStore.Properties.Resources.icons8_coffee_cup_24;
            this.button_nav_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nav_product.Location = new System.Drawing.Point(25, 103);
            this.button_nav_product.Name = "button_nav_product";
            this.button_nav_product.Size = new System.Drawing.Size(162, 60);
            this.button_nav_product.TabIndex = 1;
            this.button_nav_product.Text = "Sản phẩm";
            this.button_nav_product.UseVisualStyleBackColor = true;
            // 
            // button_nav_dashboard
            // 
            this.button_nav_dashboard.FlatAppearance.BorderSize = 0;
            this.button_nav_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nav_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_nav_dashboard.Image = global::CoffeeEcommerceStore.Properties.Resources.icons8_home_24;
            this.button_nav_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nav_dashboard.Location = new System.Drawing.Point(25, 37);
            this.button_nav_dashboard.Name = "button_nav_dashboard";
            this.button_nav_dashboard.Size = new System.Drawing.Size(162, 60);
            this.button_nav_dashboard.TabIndex = 1;
            this.button_nav_dashboard.Text = "Trang chủ";
            this.button_nav_dashboard.UseVisualStyleBackColor = true;
            // 
            // FormLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1158, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLayout";
            this.Text = "Cửa hàng";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_nav_revenue;
        private System.Windows.Forms.Button button_nav_order;
        private System.Windows.Forms.Button button_nav_product;
        private System.Windows.Forms.Button button_nav_dashboard;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button_current_user;
    }
}


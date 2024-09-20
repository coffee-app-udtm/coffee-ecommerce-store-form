namespace CoffeeEcommerceStore
{
    partial class FormSale
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_products = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_selected_product_price = new System.Windows.Forms.Label();
            this.label_selected_product_name = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_add_product = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.pictureBox_selected_product_image = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_selected_product_image)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1337, 781);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.flowLayoutPanel_products);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 771);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel_products
            // 
            this.flowLayoutPanel_products.AutoScroll = true;
            this.flowLayoutPanel_products.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_products.Location = new System.Drawing.Point(0, 97);
            this.flowLayoutPanel_products.Name = "flowLayoutPanel_products";
            this.flowLayoutPanel_products.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.flowLayoutPanel_products.Size = new System.Drawing.Size(925, 674);
            this.flowLayoutPanel_products.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button_search);
            this.panel3.Controls.Add(this.comboBox_category);
            this.panel3.Controls.Add(this.textBox_search);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 97);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh mục";
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.ItemHeight = 16;
            this.comboBox_category.Location = new System.Drawing.Point(12, 49);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(165, 24);
            this.comboBox_category.TabIndex = 1;
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_search.Location = new System.Drawing.Point(197, 28);
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(198, 45);
            this.textBox_search.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(938, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 775);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox_selected_product_image, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(396, 445);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.Controls.Add(this.label_selected_product_price);
            this.panel4.Controls.Add(this.label_selected_product_name);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 127);
            this.panel4.TabIndex = 17;
            // 
            // label_selected_product_price
            // 
            this.label_selected_product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_selected_product_price.Location = new System.Drawing.Point(8, 96);
            this.label_selected_product_price.Name = "label_selected_product_price";
            this.label_selected_product_price.Size = new System.Drawing.Size(180, 24);
            this.label_selected_product_price.TabIndex = 16;
            // 
            // label_selected_product_name
            // 
            this.label_selected_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_selected_product_name.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_selected_product_name.Location = new System.Drawing.Point(7, 16);
            this.label_selected_product_name.Name = "label_selected_product_name";
            this.label_selected_product_name.Size = new System.Drawing.Size(181, 69);
            this.label_selected_product_name.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button_add_product);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(201, 358);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(192, 84);
            this.panel6.TabIndex = 18;
            // 
            // button_add_product
            // 
            this.button_add_product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add_product.BackColor = System.Drawing.Color.Snow;
            this.button_add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_product.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_add_product.ForeColor = System.Drawing.Color.Orange;
            this.button_add_product.Location = new System.Drawing.Point(2, 28);
            this.button_add_product.Name = "button_add_product";
            this.button_add_product.Size = new System.Drawing.Size(187, 53);
            this.button_add_product.TabIndex = 14;
            this.button_add_product.Text = "Thêm vào";
            this.button_add_product.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.numericUpDown_quantity);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 358);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(192, 84);
            this.panel7.TabIndex = 19;
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_quantity.Location = new System.Drawing.Point(5, 46);
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(183, 22);
            this.numericUpDown_quantity.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Snow;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button_confirm);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 445);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 330);
            this.panel5.TabIndex = 0;
            // 
            // button_confirm
            // 
            this.button_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(121)))), ((int)(((byte)(5)))));
            this.button_confirm.FlatAppearance.BorderSize = 0;
            this.button_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirm.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_confirm.ForeColor = System.Drawing.Color.Snow;
            this.button_confirm.Location = new System.Drawing.Point(3, 269);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(387, 57);
            this.button_confirm.TabIndex = 14;
            this.button_confirm.Text = "Xác nhận thanh toán";
            this.button_confirm.UseVisualStyleBackColor = false;
            // 
            // button_search
            // 
            this.button_search.Image = global::CoffeeEcommerceStore.Properties.Resources.icons8_search_24;
            this.button_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_search.Location = new System.Drawing.Point(414, 28);
            this.button_search.Name = "button_search";
            this.button_search.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_search.Size = new System.Drawing.Size(134, 45);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Tìm kiếm";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // pictureBox_selected_product_image
            // 
            this.pictureBox_selected_product_image.BackColor = System.Drawing.Color.Snow;
            this.pictureBox_selected_product_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_selected_product_image.Image = global::CoffeeEcommerceStore.Properties.Resources.coffee_placeholder;
            this.pictureBox_selected_product_image.Location = new System.Drawing.Point(201, 3);
            this.pictureBox_selected_product_image.Name = "pictureBox_selected_product_image";
            this.pictureBox_selected_product_image.Size = new System.Drawing.Size(192, 127);
            this.pictureBox_selected_product_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_selected_product_image.TabIndex = 0;
            this.pictureBox_selected_product_image.TabStop = false;
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 787);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSale";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "FormDashboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_selected_product_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox_selected_product_image;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_add_product;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_selected_product_price;
        private System.Windows.Forms.Label label_selected_product_name;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_products;
    }
}
namespace CoffeeEcommerceStore._Form.Order
{
    partial class FormOrder
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
            this.dataGridView_orders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_orders
            // 
            this.dataGridView_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_orders.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_orders.Name = "dataGridView_orders";
            this.dataGridView_orders.RowHeadersWidth = 51;
            this.dataGridView_orders.RowTemplate.Height = 24;
            this.dataGridView_orders.Size = new System.Drawing.Size(1247, 590);
            this.dataGridView_orders.TabIndex = 0;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 590);
            this.Controls.Add(this.dataGridView_orders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_orders;
    }
}
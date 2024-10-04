namespace CoffeeEcommerceStore._Form.Order
{
    partial class FormOrderDetail
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
            this.ucOrderDetail1 = new UCOrder.UCOrderDetail();
            this.SuspendLayout();
            // 
            // ucOrderDetail1
            // 
            this.ucOrderDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOrderDetail1.Location = new System.Drawing.Point(0, 0);
            this.ucOrderDetail1.Name = "ucOrderDetail1";
            this.ucOrderDetail1.order = null;
            this.ucOrderDetail1.Size = new System.Drawing.Size(1164, 654);
            this.ucOrderDetail1.TabIndex = 0;
            // 
            // FormOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 654);
            this.Controls.Add(this.ucOrderDetail1);
            this.Name = "FormOrderDetail";
            this.Text = "FormOrderDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private UCOrder.UCOrderDetail ucOrderDetail1;
    }
}
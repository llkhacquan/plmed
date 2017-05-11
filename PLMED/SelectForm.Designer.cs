namespace PLMED
{
    partial class SelectForm
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
            System.Windows.Forms.Button button_customer;
            System.Windows.Forms.Button button_staff;
            System.Windows.Forms.Button button_product;
            System.Windows.Forms.Button button_contract;
            System.Windows.Forms.Button button_report;
            button_customer = new System.Windows.Forms.Button();
            button_staff = new System.Windows.Forms.Button();
            button_product = new System.Windows.Forms.Button();
            button_contract = new System.Windows.Forms.Button();
            button_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_customer
            // 
            button_customer.Location = new System.Drawing.Point(12, 12);
            button_customer.Name = "button_customer";
            button_customer.Size = new System.Drawing.Size(213, 117);
            button_customer.TabIndex = 0;
            button_customer.Text = "Khách hàng";
            button_customer.UseVisualStyleBackColor = true;
            button_customer.Click += new System.EventHandler(this.button_customer_Click);
            // 
            // button_staff
            // 
            button_staff.Location = new System.Drawing.Point(231, 12);
            button_staff.Name = "button_staff";
            button_staff.Size = new System.Drawing.Size(213, 117);
            button_staff.TabIndex = 1;
            button_staff.Text = "Nhân viên";
            button_staff.UseVisualStyleBackColor = true;
            button_staff.Click += new System.EventHandler(this.button_staff_Click);
            // 
            // button_product
            // 
            button_product.Location = new System.Drawing.Point(12, 135);
            button_product.Name = "button_product";
            button_product.Size = new System.Drawing.Size(213, 117);
            button_product.TabIndex = 2;
            button_product.Text = "Sản phẩm";
            button_product.UseVisualStyleBackColor = true;
            button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // button_contract
            // 
            button_contract.Location = new System.Drawing.Point(231, 135);
            button_contract.Name = "button_contract";
            button_contract.Size = new System.Drawing.Size(213, 117);
            button_contract.TabIndex = 3;
            button_contract.Text = "Hợp đồng";
            button_contract.UseVisualStyleBackColor = true;
            button_contract.Click += new System.EventHandler(this.button_contract_Click);
            // 
            // button_report
            // 
            button_report.Location = new System.Drawing.Point(12, 258);
            button_report.Name = "button_report";
            button_report.Size = new System.Drawing.Size(432, 117);
            button_report.TabIndex = 4;
            button_report.Text = "Báo cáo";
            button_report.UseVisualStyleBackColor = true;
            button_report.Click += new System.EventHandler(this.button_report_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 380);
            this.Controls.Add(button_report);
            this.Controls.Add(button_contract);
            this.Controls.Add(button_product);
            this.Controls.Add(button_staff);
            this.Controls.Add(button_customer);
            this.Name = "SelectForm";
            this.Text = "Xin chọn một bảng";
            this.ResumeLayout(false);

        }

        #endregion
    }
}
namespace PLMED
{
    partial class ContractDetailForm
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
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.dateTimePicker_signdate = new System.Windows.Forms.DateTimePicker();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.comboBox_customer = new System.Windows.Forms.ComboBox();
            this.numericUpDown_value = new System.Windows.Forms.NumericUpDown();
            this.comboBox_staff = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_value)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(512, 11);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(22, 13);
            label8.TabIndex = 53;
            label8.Text = "Mã";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(9, 293);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 13);
            label6.TabIndex = 50;
            label6.Text = "Ngày ký";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(9, 234);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(34, 13);
            label5.TabIndex = 49;
            label5.Text = "Giá trị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(9, 176);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 13);
            label4.TabIndex = 47;
            label4.Text = "Nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 120);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 13);
            label3.TabIndex = 45;
            label3.Text = "Khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 13);
            label2.TabIndex = 43;
            label2.Text = "Tên hợp đồng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 13);
            label1.TabIndex = 41;
            label1.Text = "Mã hợp đồng";
            // 
            // dateTimePicker_signdate
            // 
            this.dateTimePicker_signdate.Location = new System.Drawing.Point(133, 286);
            this.dateTimePicker_signdate.Name = "dateTimePicker_signdate";
            this.dateTimePicker_signdate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_signdate.TabIndex = 54;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(570, 8);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(75, 20);
            this.textBox_id.TabIndex = 52;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(133, 63);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(277, 20);
            this.textBox_name.TabIndex = 42;
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(133, 12);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(277, 20);
            this.textBox_code.TabIndex = 40;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(570, 354);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 39;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.Location = new System.Drawing.Point(473, 354);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 38;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Location = new System.Drawing.Point(133, 117);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(277, 21);
            this.comboBox_customer.TabIndex = 55;
            // 
            // numericUpDown_value
            // 
            this.numericUpDown_value.Location = new System.Drawing.Point(133, 234);
            this.numericUpDown_value.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numericUpDown_value.Name = "numericUpDown_value";
            this.numericUpDown_value.Size = new System.Drawing.Size(277, 20);
            this.numericUpDown_value.TabIndex = 56;
            // 
            // comboBox_staff
            // 
            this.comboBox_staff.FormattingEnabled = true;
            this.comboBox_staff.Location = new System.Drawing.Point(133, 176);
            this.comboBox_staff.Name = "comboBox_staff";
            this.comboBox_staff.Size = new System.Drawing.Size(277, 21);
            this.comboBox_staff.TabIndex = 57;
            // 
            // ContractDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 389);
            this.Controls.Add(this.comboBox_staff);
            this.Controls.Add(this.numericUpDown_value);
            this.Controls.Add(this.comboBox_customer);
            this.Controls.Add(this.dateTimePicker_signdate);
            this.Controls.Add(label8);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_OK);
            this.Name = "ContractDetailForm";
            this.Text = "ContractDetailForm";
            this.Load += new System.EventHandler(this.ContractDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker_signdate;
        public System.Windows.Forms.TextBox textBox_id;
        public System.Windows.Forms.TextBox textBox_name;
        public System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.ComboBox comboBox_customer;
        private System.Windows.Forms.NumericUpDown numericUpDown_value;
        private System.Windows.Forms.ComboBox comboBox_staff;
    }
}
namespace PLMED
{
    partial class ProductDetailForm
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.numericUpDown_price = new System.Windows.Forms.NumericUpDown();
            label8 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(509, 11);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(22, 13);
            label8.TabIndex = 53;
            label8.Text = "Mã";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 176);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(23, 13);
            label4.TabIndex = 47;
            label4.Text = "Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 120);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 13);
            label3.TabIndex = 45;
            label3.Text = "Loại sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(26, 13);
            label2.TabIndex = 43;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 13);
            label1.TabIndex = 41;
            label1.Text = "Mã sản phẩm";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(567, 8);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(75, 20);
            this.textBox_id.TabIndex = 52;
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(130, 117);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(277, 20);
            this.textBox_type.TabIndex = 44;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(130, 63);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(277, 20);
            this.textBox_name.TabIndex = 42;
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(130, 12);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(277, 20);
            this.textBox_code.TabIndex = 40;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(577, 175);
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
            this.btn_OK.Location = new System.Drawing.Point(480, 175);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 38;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // numericUpDown_price
            // 
            this.numericUpDown_price.Location = new System.Drawing.Point(130, 169);
            this.numericUpDown_price.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numericUpDown_price.Name = "numericUpDown_price";
            this.numericUpDown_price.Size = new System.Drawing.Size(277, 20);
            this.numericUpDown_price.TabIndex = 54;
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 210);
            this.Controls.Add(this.numericUpDown_price);
            this.Controls.Add(label8);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.textBox_type);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_OK);
            this.Name = "ProductDetailForm";
            this.Text = "ProductDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_id;
        public System.Windows.Forms.TextBox textBox_type;
        public System.Windows.Forms.TextBox textBox_name;
        public System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.NumericUpDown numericUpDown_price;
    }
}
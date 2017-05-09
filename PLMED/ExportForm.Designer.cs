namespace PLMED
{
    partial class ExportForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Button button_time_this_month;
            System.Windows.Forms.Button button_time_last_month;
            System.Windows.Forms.Button button_time_this_week;
            System.Windows.Forms.Button button_time_this_year;
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox_staff = new System.Windows.Forms.ComboBox();
            this.comboBox_customer = new System.Windows.Forms.ComboBox();
            this.checkBox_staff = new System.Windows.Forms.CheckBox();
            this.checkBox_customer = new System.Windows.Forms.CheckBox();
            this.button_export = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button_time_this_month = new System.Windows.Forms.Button();
            button_time_last_month = new System.Windows.Forms.Button();
            button_time_this_week = new System.Windows.Forms.Button();
            button_time_this_year = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(20, 13);
            label1.TabIndex = 2;
            label1.Text = "Từ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(244, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(27, 13);
            label2.TabIndex = 3;
            label2.Text = "Đến";
            // 
            // button_time_this_month
            // 
            button_time_this_month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            button_time_this_month.Location = new System.Drawing.Point(706, 8);
            button_time_this_month.Name = "button_time_this_month";
            button_time_this_month.Size = new System.Drawing.Size(75, 23);
            button_time_this_month.TabIndex = 9;
            button_time_this_month.Text = "Tháng này";
            button_time_this_month.UseVisualStyleBackColor = true;
            button_time_this_month.Click += new System.EventHandler(this.button_time_this_month_Click);
            // 
            // button_time_last_month
            // 
            button_time_last_month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            button_time_last_month.Location = new System.Drawing.Point(787, 8);
            button_time_last_month.Name = "button_time_last_month";
            button_time_last_month.Size = new System.Drawing.Size(75, 23);
            button_time_last_month.TabIndex = 10;
            button_time_last_month.Text = "Tháng trước";
            button_time_last_month.UseVisualStyleBackColor = true;
            button_time_last_month.Click += new System.EventHandler(this.button_time_last_month_Click);
            // 
            // button_time_this_week
            // 
            button_time_this_week.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            button_time_this_week.Location = new System.Drawing.Point(868, 8);
            button_time_this_week.Name = "button_time_this_week";
            button_time_this_week.Size = new System.Drawing.Size(75, 23);
            button_time_this_week.TabIndex = 11;
            button_time_this_week.Text = "Tuần này";
            button_time_this_week.UseVisualStyleBackColor = true;
            button_time_this_week.Click += new System.EventHandler(this.button_time_this_week_Click);
            // 
            // button_time_this_year
            // 
            button_time_this_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            button_time_this_year.Location = new System.Drawing.Point(949, 8);
            button_time_this_year.Name = "button_time_this_year";
            button_time_this_year.Size = new System.Drawing.Size(75, 23);
            button_time_this_year.TabIndex = 12;
            button_time_this_year.Text = "Năm nay";
            button_time_this_year.UseVisualStyleBackColor = true;
            button_time_this_year.Click += new System.EventHandler(this.button_time_this_year_Click);
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Location = new System.Drawing.Point(38, 12);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_from.TabIndex = 0;
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Location = new System.Drawing.Point(277, 12);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_to.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 125);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1012, 525);
            this.dataGridView.TabIndex = 4;
            // 
            // comboBox_staff
            // 
            this.comboBox_staff.FormattingEnabled = true;
            this.comboBox_staff.Location = new System.Drawing.Point(117, 57);
            this.comboBox_staff.Name = "comboBox_staff";
            this.comboBox_staff.Size = new System.Drawing.Size(360, 21);
            this.comboBox_staff.TabIndex = 5;
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Location = new System.Drawing.Point(117, 84);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(360, 21);
            this.comboBox_customer.TabIndex = 6;
            // 
            // checkBox_staff
            // 
            this.checkBox_staff.AutoSize = true;
            this.checkBox_staff.Location = new System.Drawing.Point(12, 59);
            this.checkBox_staff.Name = "checkBox_staff";
            this.checkBox_staff.Size = new System.Drawing.Size(75, 17);
            this.checkBox_staff.TabIndex = 7;
            this.checkBox_staff.Text = "Nhân viên";
            this.checkBox_staff.UseVisualStyleBackColor = true;
            // 
            // checkBox_customer
            // 
            this.checkBox_customer.AutoSize = true;
            this.checkBox_customer.Location = new System.Drawing.Point(12, 88);
            this.checkBox_customer.Name = "checkBox_customer";
            this.checkBox_customer.Size = new System.Drawing.Size(84, 17);
            this.checkBox_customer.TabIndex = 8;
            this.checkBox_customer.Text = "Khách hàng";
            this.checkBox_customer.UseVisualStyleBackColor = true;
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(868, 82);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(156, 23);
            this.button_export.TabIndex = 13;
            this.button_export.Text = "Tạo file excel";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(499, 57);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(81, 48);
            this.button_load.TabIndex = 14;
            this.button_load.Text = "Tìm kiếm";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 662);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_export);
            this.Controls.Add(button_time_this_year);
            this.Controls.Add(button_time_this_week);
            this.Controls.Add(button_time_last_month);
            this.Controls.Add(button_time_this_month);
            this.Controls.Add(this.checkBox_customer);
            this.Controls.Add(this.checkBox_staff);
            this.Controls.Add(this.comboBox_customer);
            this.Controls.Add(this.comboBox_staff);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.dateTimePicker_from);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.Load += new System.EventHandler(this.ExportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBox_staff;
        private System.Windows.Forms.ComboBox comboBox_customer;
        private System.Windows.Forms.CheckBox checkBox_staff;
        private System.Windows.Forms.CheckBox checkBox_customer;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_load;
    }
}
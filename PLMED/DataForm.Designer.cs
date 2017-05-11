using PLMED.entity;

namespace PLMED
{
    partial class DataForm<T>
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
            System.Windows.Forms.Button btn_delete;
            System.Windows.Forms.Button btn_edit;
            System.Windows.Forms.Button btn_new;
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button_search = new System.Windows.Forms.Button();
            btn_delete = new System.Windows.Forms.Button();
            btn_edit = new System.Windows.Forms.Button();
            btn_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btn_delete.Image = global::PLMED.Properties.Resources.Delete_50;
            btn_delete.Location = new System.Drawing.Point(850, 276);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new System.Drawing.Size(123, 82);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "Xóa";
            btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btn_edit.Image = global::PLMED.Properties.Resources.Edit_50;
            btn_edit.Location = new System.Drawing.Point(850, 188);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new System.Drawing.Size(123, 82);
            btn_edit.TabIndex = 9;
            btn_edit.Text = "Sửa";
            btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_new
            // 
            btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btn_new.Image = global::PLMED.Properties.Resources.Add_List_50;
            btn_new.Location = new System.Drawing.Point(850, 100);
            btn_new.Name = "btn_new";
            btn_new.Size = new System.Drawing.Size(123, 82);
            btn_new.TabIndex = 6;
            btn_new.Text = "Tạo mới";
            btn_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Location = new System.Drawing.Point(12, 12);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(824, 20);
            this.textBox_search.TabIndex = 11;
            this.textBox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_search_KeyPress);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 38);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(824, 598);
            this.dataGridView.TabIndex = 7;
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.Image = global::PLMED.Properties.Resources.Search_50;
            this.button_search.Location = new System.Drawing.Point(850, 12);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(123, 82);
            this.button_search.TabIndex = 8;
            this.button_search.Text = "Tìm kiếm";
            this.button_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 648);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(btn_delete);
            this.Controls.Add(btn_edit);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(btn_new);
            this.Name = "DataForm";
            this.Text = "DataForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button_search;
    }
}
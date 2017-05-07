using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLMED.entity;
using System.Data.SqlClient;

namespace PLMED
{
    internal partial class DataForm<T> : Form where T : Entity
    {
        private IDetailForm form = null;
        private IDetailForm DetailForm
        {
            get
            {
                if (form == null)
                {
                    if (typeof(T) == typeof(Customer))
                    {
                        form = new CustomerDetailForm();
                    }
                    else if (typeof(T) == typeof(Staff))
                    {
                        form = new StaffDetailForm();
                    }
                    else if (typeof(T) == typeof(Product))
                    {
                        form = new ProductDetailForm();
                    }
                    else if(typeof(T) == typeof(Contract))
                    {
                        form = new ContractDetailForm();
                    }
                    else
                    {
                        throw new Exception("Cannot detect type of T : " + typeof(T));
                    }
                }
                return form;
            }
        }

        public DataForm()
        {
            InitializeComponent();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (DetailForm.create())
            {
                loadData(null);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dataGridView.SelectedRows;
            foreach (DataGridViewRow row in selectedRow)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                if (DetailForm.delete(id))
                {
                    loadData(null);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dataGridView.SelectedRows;
            foreach (DataGridViewRow row in selectedRow)
            {
                if (DetailForm.update(row))
                {
                    loadData(null);
                }
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            loadData(textBox_search.Text);
        }

        internal void loadData(string query)
        {
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlDataAdapter dataadapter;
            SqlCommand cmdSearch = DetailForm.load(typeof(T), query);
            cmdSearch.Connection = conn;
            dataadapter = new SqlDataAdapter(cmdSearch);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                dataadapter.Fill(ds, "data table");
                conn.Close();
                dataGridView.DataSource = ds;
                dataGridView.DataMember = "data table";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Làm mới không thành công!\nLỗi : " + ex.Message);
            }
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // ENTER
            {
                button_search.PerformClick();
            }
            else if (e.KeyChar == 27) // ESC
            {
                textBox_search.Text = "";
                button_search_Click(sender, null);
            }
        }
    }
}

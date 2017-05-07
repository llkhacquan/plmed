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
        private IDetailForm form;
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
            string connectionString = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connectionString);
            Table t = null;
            if (typeof(T) == typeof(Customer))
            {
                t = Table.CustomerTable;
            }
            else if (typeof(T) == typeof(Staff))
            {
                t = Table.StaffTable;
            }
            else if (typeof(T) == typeof(Product))
            {
                t = Table.ProductTable;
            }
            else
            {
                throw new Exception("Cannot detect type of T : " + typeof(T));
            }

            StringBuilder sql = new StringBuilder("SELECT * FROM " + t.name);
            SqlDataAdapter dataadapter;
            if (query == null)
            {
                dataadapter = new SqlDataAdapter(sql.ToString(), conn);
            }
            else
            {
                query = query.ToUpper();
                sql.Append("\nWHERE ");
                foreach (Field f in t.fields)
                {
                    sql.Append("UPPER(");
                    if (f is StringField)
                    {
                        sql.Append(f.nameInDB);
                    }
                    else
                    {
                        sql.Append("STR(").Append(f.nameInDB).Append(") ");
                    }
                    sql.Append(")");
                    sql.Append(" like '%").Append(query).Append("%' ");
                    sql.Append("\nOR ");
                }
                sql.Remove(sql.Length - 4, 4);
                SqlCommand cmdSearch = new SqlCommand(sql.ToString(), conn);
                dataadapter = new SqlDataAdapter(cmdSearch);
            }
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
                button_search_Click(sender, null);
            }
            else if (e.KeyChar == 27) // ESC
            {
                textBox_search.Text = "";
                button_search_Click(sender, null);
            }
        }
    }
}

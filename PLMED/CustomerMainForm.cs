using PLMED.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLMED
{
    public partial class CustomerMainFrom : Form
    {
        private IDetailForm form = new CustomerDetailForm();

        public CustomerMainFrom()
        {
            InitializeComponent();
            loadCustomers(false);
        }

        private void loadCustomers(Boolean search)
        {
            string connectionString = Utility.GetConnectionString();
            SqlConnection conn = new SqlConnection(connectionString);
            string sql = "SELECT * FROM [Sales].[Customer]";

            SqlDataAdapter dataadapter;
            if (!search)
            {
                dataadapter = new SqlDataAdapter(sql, conn);
            }
            else
            {
                SqlCommand cmdSearchCustomer = new SqlCommand("Sales.uspSearchCustomer", conn);
                cmdSearchCustomer.CommandType = CommandType.StoredProcedure;
                cmdSearchCustomer.Parameters.Add(new SqlParameter("@query", SqlDbType.NVarChar, 100));
                cmdSearchCustomer.Parameters["@query"].Value = textBox_search.Text;
                dataadapter = new SqlDataAdapter(cmdSearchCustomer);
            }
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                dataadapter.Fill(ds, "Authors_table");
                conn.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Authors_table";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Làm mới khách hàng không thành công!\nLỗi : " + ex.Message);
            }
        }

        private void btn_newCustomer_Click(object sender, EventArgs e)
        {
            CustomerDetailForm form = new CustomerDetailForm();
            form.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadCustomers(false);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in selectedRow)
            {
                if (form.update(row))
                {
                    loadCustomers(false);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in selectedRow)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                if (form.delete(id))
                {
                    loadCustomers(false);
                }
            }
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // ENTER
            {
                searchCustomer();
            }
        }

        private void searchCustomer()
        {
            loadCustomers(true);
        }
    }
}

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
    internal partial class CustomerDetailForm : IDetailForm
    {
        Boolean editMode = false;
        Boolean result;

        public CustomerDetailForm()
        {
            InitializeComponent();
            textBox_name.Text = RandomString(20);
            textBox_email.Text = RandomString(10);
            textBox_taxCode.Text = RandomString(10);
            textBox_category.Text = RandomString(10);
            textBox_address.Text = RandomString(10);
            textBox_telephone.Text = RandomString(10);
            textBox_contact.Text = RandomString(10);
        }

        private static Random random = new Random();
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (isCustomerInfoOK())
            {
                if (editMode)
                {
                    result = updateCustomer();
                }
                else
                {
                    result = createCustomer();
                }
                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private bool updateCustomer()
        {
            Boolean success = true;
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdUpdateCustomer = new SqlCommand("Sales.uspUpdateCustomer", conn);
            cmdUpdateCustomer.CommandType = CommandType.StoredProcedure;
            addParameters(cmdUpdateCustomer);
            cmdUpdateCustomer.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmdUpdateCustomer.Parameters["@id"].Value = textBox_id.Text;
            try
            {
                conn.Open();
                cmdUpdateCustomer.ExecuteNonQuery();
                MessageBox.Show("Cập nhật khách hàng thành công!");
            }
            catch (Exception exception)
            {
                success = false;
                MessageBox.Show("Cập nhật khách hàng không thành công.\nLỗi : " + exception.Message);                
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        private void addParameters(SqlCommand cmdNewCustomer)
        {
            cmdNewCustomer.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 100));
            cmdNewCustomer.Parameters["@name"].Value = textBox_name.Text;
            cmdNewCustomer.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 100));
            cmdNewCustomer.Parameters["@email"].Value = textBox_email.Text;
            cmdNewCustomer.Parameters.Add(new SqlParameter("@taxcode", SqlDbType.NVarChar, 100));
            cmdNewCustomer.Parameters["@taxcode"].Value = textBox_taxCode.Text;
            cmdNewCustomer.Parameters.Add(new SqlParameter("@category", SqlDbType.NVarChar, 100));
            cmdNewCustomer.Parameters["@category"].Value = textBox_category.Text;
            cmdNewCustomer.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar, 100));
            cmdNewCustomer.Parameters["@address"].Value = textBox_address.Text;
            cmdNewCustomer.Parameters.Add(new SqlParameter("@telephone", SqlDbType.NVarChar, 100));
            cmdNewCustomer.Parameters["@telephone"].Value = textBox_telephone.Text;
            cmdNewCustomer.Parameters.Add(new SqlParameter("@contact", SqlDbType.NVarChar, 100));
            cmdNewCustomer.Parameters["@contact"].Value = textBox_contact.Text;
        }

        private Boolean isCustomerInfoOK()
        {
            return textBox_name.Text.Length > 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        internal override bool delete(int id)
        {
            bool success = true;
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdDeleteCustomer = new SqlCommand("Sales.uspDeleteCustomer", conn);
            cmdDeleteCustomer.CommandType = CommandType.StoredProcedure;
            cmdDeleteCustomer.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmdDeleteCustomer.Parameters["@id"].Value = id;
            try
            {
                conn.Open();
                cmdDeleteCustomer.ExecuteNonQuery();
                MessageBox.Show("Xóa khách hàng thành công!");
            }
            catch (Exception exception)
            {
                success = false;
                MessageBox.Show("Xóa khách hàng không thành công.\nLỗi : " + exception.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        internal override bool create()
        {
            textBox_name.Text = "";
            textBox_address.Text = "";
            textBox_category.Text = "";
            textBox_taxCode.Text = "";
            textBox_email.Text = "";
            textBox_telephone.Text = "";
            textBox_contact.Text = "";

            this.Text = "Thêm khách hàng";
            textBox_id.Text = "";
            editMode = false;
            ShowDialog();
            if (DialogResult == DialogResult.OK)
                return result;
            else
                return false;            
        }

        private bool createCustomer()
        {
            bool success = true;
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdNewCustomer = new SqlCommand("Sales.uspNewCustomer", conn);
            cmdNewCustomer.CommandType = CommandType.StoredProcedure;
            addParameters(cmdNewCustomer);
            cmdNewCustomer.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmdNewCustomer.Parameters["@id"].Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                cmdNewCustomer.ExecuteNonQuery();
                int customerId = (int)cmdNewCustomer.Parameters["@id"].Value;
            }
            catch (Exception exception)
            {
                success = false;
                MessageBox.Show("Account could not be created.\n" + exception.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        internal override bool update(DataGridViewRow row)
        {
            textBox_id.Text = (string) row.Cells[0].Value;
            textBox_name.Text = row.Cells[1].Value.ToString();
            textBox_email.Text = row.Cells[2].Value.ToString();
            textBox_taxCode.Text = row.Cells[3].Value.ToString();
            textBox_category.Text = row.Cells[4].Value.ToString();
            textBox_address.Text = row.Cells[5].Value.ToString();
            textBox_telephone.Text = row.Cells[6].Value.ToString();
            textBox_contact.Text = row.Cells[7].Value.ToString();

            this.Text = "Sửa khách hàng";
            editMode = true;
            this.ShowDialog();
            if (DialogResult == DialogResult.OK)
                return result;
            else
                return false;
        }
        
    }


}

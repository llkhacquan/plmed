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
    internal partial class ContractDetailForm : IDetailForm
    {
        public ContractDetailForm()
        {
            InitializeComponent();
        }

        internal override SqlCommand load(Type type, string query)
        {
            if (query == null)
            {
                SqlCommand cmd = new SqlCommand("[Sales].[selectContract]");
                cmd.CommandType = CommandType.StoredProcedure;
                return cmd;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("[Sales].[searchContract]");
                cmd.Parameters.Add("@query", SqlDbType.NVarChar, 100).Value = query.ToUpper();
                cmd.CommandType = CommandType.StoredProcedure;
                return cmd;
            }
        }

        internal override bool create()
        {
            textBox_code.Text = Utility.RandomString(10);
            textBox_name.Text = Utility.RandomString(10);
            numericUpDown_value.Value = 12345;
            this.Text = "Thêm hợp đồng";
            textBox_id.Text = "";
            editMode = false;
            ShowDialog();
            return result;
        }

        internal override bool delete(int id)
        {
            bool success = true;
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdDelete = new SqlCommand("Sales.deleteContract", conn);
            cmdDelete.CommandType = CommandType.StoredProcedure;
            cmdDelete.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmdDelete.Parameters["@id"].Value = id;
            try
            {
                conn.Open();
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Xóa hợp đồng thành công!");
            }
            catch (Exception exception)
            {
                success = false;
                MessageBox.Show("Xóa hợp đồng không thành công.\nLỗi : " + exception.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        internal override bool update(DataGridViewRow row)
        {
            textBox_id.Text = row.Cells[0].Value.ToString();
            textBox_code.Text = row.Cells[1].Value.ToString();
            textBox_name.Text = row.Cells[2].Value.ToString();

            this.Text = "Sửa hợp đồng";
            editMode = true;
            this.ShowDialog();
            return result;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (isInfoOK())
            {
                if (editMode)
                {
                    result = updateContract();
                }
                else
                {
                    result = createContract();
                }
                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private bool updateContract()
        {
            Boolean success = true;
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdUpdateContract = new SqlCommand("Sales.updateContract", conn);
            cmdUpdateContract.CommandType = CommandType.StoredProcedure;
            addParameters(cmdUpdateContract);
            cmdUpdateContract.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmdUpdateContract.Parameters["@id"].Value = textBox_id.Text;
            try
            {
                conn.Open();
                cmdUpdateContract.ExecuteNonQuery();
                MessageBox.Show("Cập nhật hợp đồng thành công!");
            }
            catch (Exception exception)
            {
                success = false;
                MessageBox.Show("Cập nhật hợp đồng không thành công.\nLỗi : " + exception.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        private bool createContract()
        {
            bool success = true;
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdNewContract = new SqlCommand("Sales.newContract", conn);
            cmdNewContract.CommandType = CommandType.StoredProcedure;
            addParameters(cmdNewContract);
            cmdNewContract.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmdNewContract.Parameters["@id"].Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                cmdNewContract.ExecuteNonQuery();
                int customerId = (int)cmdNewContract.Parameters["@id"].Value;
            }
            catch (Exception exception)
            {
                success = false;
                MessageBox.Show("Không thể tạo hợp đồng.\n" + exception.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        private void loadComboBoxes()
        {
            comboBox_customer.DataSource = loadCustomers();
            comboBox_customer.DisplayMember = "name";
            comboBox_customer.ValueMember = "id";

            comboBox_staff.DataSource = loadStaffs();
            comboBox_staff.DisplayMember = "name";
            comboBox_staff.ValueMember = "id";
        }

        private List<Customer> loadCustomers()
        {
            List<Customer> customers = new List<Customer>();
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdSelectCustomer = new SqlCommand("SELECT * from [Sales].[Customer]", conn);
            try
            {
                conn.Open();
                SqlDataReader customersReader = cmdSelectCustomer.ExecuteReader();

                while (customersReader.Read())
                {
                    Customer c = new Customer();
                    c.id = (int)customersReader["id"];
                    c.Name = (string)customersReader["name"];
                    customers.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được dữ liệu về khách hàng!\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return customers;
        }

        private List<Staff> loadStaffs()
        {
            List<Staff> staffs = new List<Staff>();
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdSelectCustomer = new SqlCommand("SELECT * from [Sales].[Staff]", conn);
            try
            {
                conn.Open();
                SqlDataReader staffsReader = cmdSelectCustomer.ExecuteReader();

                while (staffsReader.Read())
                {
                    Staff c = new Staff();
                    c.id = (int)staffsReader["id"];
                    c.Name = (string)staffsReader["name"];
                    staffs.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được dữ liệu về khách hàng!\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return staffs;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            result = false;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void addParameters(SqlCommand cmd)
        {
            cmd.Parameters.Add("@code", SqlDbType.NVarChar, 100).Value = textBox_code.Text;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = textBox_name.Text;
            cmd.Parameters.Add("@value", SqlDbType.BigInt).Value = numericUpDown_value.Value;
            cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = (comboBox_customer.SelectedItem as Customer).id;
            cmd.Parameters.Add("@staff_id", SqlDbType.Int).Value = (comboBox_staff.SelectedItem as Staff).id;
            cmd.Parameters.Add("@signdate", SqlDbType.Date).Value = dateTimePicker_signdate.Value.Date;
        }

        private void ContractDetailForm_Load(object sender, EventArgs e)
        {
            loadComboBoxes();
        }

        private Boolean isInfoOK()
        {
            return textBox_name.Text.Length > 0;
        }
    }
}

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
    internal partial class StaffDetailForm : IDetailForm
    {
        public StaffDetailForm()
        {
            InitializeComponent();
        }

        internal override bool create()
        {
            textBox_code.Text = Utility.RandomString(10);
            textBox_name.Text = Utility.RandomString(10);
            textBox_address.Text = Utility.RandomString(10);
            textBox_position.Text = Utility.RandomString(10);
            textBox_telephone.Text = Utility.RandomString(10);

            this.Text = "Thêm nhân viên";
            textBox_id.Text = "";
            editMode = false;
            ShowDialog();
            return result;
        }

        internal override bool delete(int id)
        {
            bool success = true;
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdDelete = new SqlCommand("Sales.deleteStaff", conn);
            cmdDelete.CommandType = CommandType.StoredProcedure;
            cmdDelete.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmdDelete.Parameters["@id"].Value = id;
            try
            {
                conn.Open();
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Xóa nhân viên thành công!");
            }
            catch (Exception exception)
            {
                success = false;
                MessageBox.Show("Xóa nhân viên không thành công.\nLỗi : " + exception.Message);
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
            textBox_telephone.Text = row.Cells[3].Value.ToString();
            textBox_position.Text = row.Cells[4].Value.ToString();
            textBox_address.Text = row.Cells[5].Value.ToString();
            dateTimePicker_birthday.Value = (DateTime)row.Cells[6].Value;
            dateTimePicker_startWorkingDay.Value = (DateTime)row.Cells[7].Value;

            this.Text = "Sửa khách hàng";
            editMode = true;
            this.ShowDialog();
            return result;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                if (updateStaff())
                {
                    Close();
                }
            }
            else
            {
                if (createNewStaff())
                {
                    Close();
                }
                return;
            }
        }

        private bool updateStaff()
        {
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdUpdate = new SqlCommand("Sales.updateStaff", conn);
            cmdUpdate.CommandType = CommandType.StoredProcedure;
            addParameters(cmdUpdate);
            cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = Int32.Parse(textBox_id.Text);
            try
            {
                conn.Open();
                cmdUpdate.ExecuteNonQuery();
                result = true;
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception exception)
            {
                result = false;
                MessageBox.Show("Cập nhật không thành công!\n" + exception.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        private bool createNewStaff()
        {
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdNew = new SqlCommand("Sales.newStaff", conn);
            cmdNew.CommandType = CommandType.StoredProcedure;
            addParameters(cmdNew);
            cmdNew.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmdNew.Parameters["@id"].Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                cmdNew.ExecuteNonQuery();
                int customerId = (int)cmdNew.Parameters["@id"].Value;
                result = true;
                MessageBox.Show("Tạo mới thành công!");
            }
            catch (Exception exception)
            {
                result = false;
                MessageBox.Show("Account could not be created.\n" + exception.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
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
            cmd.Parameters.Add("@telephone", SqlDbType.NVarChar, 100).Value = textBox_telephone.Text;
            cmd.Parameters.Add("@position", SqlDbType.NVarChar, 100).Value = textBox_position.Text;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar, 100).Value = textBox_address.Text;
            cmd.Parameters.Add("@start", SqlDbType.Date).Value = dateTimePicker_startWorkingDay.Value.Date;
            cmd.Parameters.Add("@birthday", SqlDbType.Date).Value = dateTimePicker_birthday.Value.Date;
        }
    }
}

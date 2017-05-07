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
    internal partial class ProductDetailForm : IDetailForm
    {
        public ProductDetailForm()
        {
            InitializeComponent();
        }

        internal override bool create()
        {
            textBox_code.Text = Utility.RandomString(10);
            textBox_name.Text = Utility.RandomString(10);
            textBox_type.Text = Utility.RandomString(10);
            numericUpDown_price.Value = 100000;

            this.Text = "Thêm sản phẩm";
            textBox_id.Text = "";
            editMode = false;
            ShowDialog();
            return result;
        }

        internal override bool delete(int id)
        {
            bool success = true;
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdDelete = new SqlCommand("Sales.deleteProduct", conn);
            cmdDelete.CommandType = CommandType.StoredProcedure;
            cmdDelete.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmdDelete.Parameters["@id"].Value = id;
            try
            {
                conn.Open();
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Xóa sản phẩm thành công!");
            }
            catch (Exception exception)
            {
                success = false;
                MessageBox.Show("Xóa sản phẩm không thành công.\nLỗi : " + exception.Message);
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
            numericUpDown_price.Value = (Int64)row.Cells[3].Value;
            textBox_type.Text = row.Cells[4].Value.ToString();


            this.Text = "Sửa khách hàng";
            editMode = true;
            this.ShowDialog();
            return result;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                if (updateProduct())
                {
                    Close();
                }
            }
            else
            {
                if (createNewProduct())
                {
                    Close();
                }
                return;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            result = false;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool updateProduct()
        {
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdUpdate = new SqlCommand("Sales.updateProduct", conn);
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

        private bool createNewProduct()
        {
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdNew = new SqlCommand("Sales.newProduct", conn);
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
                MessageBox.Show("Tạo mới không thành công!\n" + exception.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        private void addParameters(SqlCommand cmd)
        {
            cmd.Parameters.Add("@code", SqlDbType.NVarChar, 100).Value = textBox_code.Text;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = textBox_name.Text;
            cmd.Parameters.Add("@type", SqlDbType.NVarChar, 100).Value = textBox_type.Text;
            cmd.Parameters.Add("@price", SqlDbType.BigInt).Value = numericUpDown_price.Value;
        }
    }
}

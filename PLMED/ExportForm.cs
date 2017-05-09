using PLMED.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLMED
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            if (!checkBox_customer.Checked && !checkBox_staff.Checked)
            {
                cmd = new SqlCommand("[Sales].[exportContract]");
            }
            else if (checkBox_customer.Checked && checkBox_staff.Checked)
            {
                cmd = new SqlCommand("[Sales].[exportContractCS]");
                cmd.Parameters.Add("@staff_id", SqlDbType.Int).Value = (comboBox_staff.SelectedItem as Staff).id;
                cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = (comboBox_customer.SelectedItem as Customer).id;
            }
            else if (checkBox_customer.Checked && !checkBox_staff.Checked)
            {
                cmd = new SqlCommand("[Sales].[exportContractC]");
                cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = (comboBox_customer.SelectedItem as Customer).id;
            }
            else if (!checkBox_customer.Checked && checkBox_staff.Checked)
            {
                cmd = new SqlCommand("[Sales].[exportContractS]");
                cmd.Parameters.Add("@staff_id", SqlDbType.Int).Value = (comboBox_staff.SelectedItem as Staff).id;
            }
            else
            {
                throw new Exception("Error!");
            }

            cmd.Parameters.Add("@fromdate", SqlDbType.Date).Value = dateTimePicker_from.Value;
            cmd.Parameters.Add("@todate", SqlDbType.Date).Value = dateTimePicker_to.Value;
            cmd.CommandType = CommandType.StoredProcedure;

            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlDataAdapter dataadapter;
            cmd.Connection = conn;
            dataadapter = new SqlDataAdapter(cmd);
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
                MessageBox.Show("Tìm kiếm không thành công!\nLỗi : " + ex.Message);
            }
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            dataGridView.SelectAll();
            DataObject dataObj = dataGridView.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void button_time_this_week_Click(object sender, EventArgs e)
        {

        }

        private void button_time_last_month_Click(object sender, EventArgs e)
        {

        }

        private void button_time_this_month_Click(object sender, EventArgs e)
        {

        }

        private void button_time_this_year_Click(object sender, EventArgs e)
        {

        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            comboBox_customer.DataSource = Utility.loadCustomers();
            comboBox_customer.DisplayMember = "name";
            comboBox_customer.ValueMember = "id";

            comboBox_staff.DataSource = Utility.loadStaffs();
            comboBox_staff.DisplayMember = "name";
            comboBox_staff.ValueMember = "id";
        }
    }
}

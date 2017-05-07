using PLMED.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLMED
{
    public partial class MainForm : Form
    {
        private readonly string USER = "User";
        private readonly string PASSWORD = "Password";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            DataForm<Staff> form = new DataForm<Staff>();
            form.loadData(null);
            Hide();
            form.ShowDialog();
            Show();
            form.Dispose();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            DataForm<Customer> form = new DataForm<Customer>();
            form.loadData(null);
            Hide();
            form.ShowDialog();
            Show();
            form.Dispose();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            DataForm<Product> form = new DataForm<Product>();
            form.loadData(null);
            Hide();
            form.ShowDialog();
            Show();
            form.Dispose();
        }

        private void btn_Contract_Click(object sender, EventArgs e)
        {
            DataForm<Contract> form = new DataForm<Contract>();
            form.loadData(null);
            Hide();
            form.ShowDialog();
            Show();
            form.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!USER.Equals(textBox_user.Text) || !PASSWORD.Equals(textBox_password.Text))
            {
                MessageBox.Show("Đăng nhập sai!");
                textBox_password.Text = "";
            }
            else
            {
                btn_Contract.Enabled = true;
                btn_Customer.Enabled = true;
                btn_Product.Enabled = true;
                btn_Staff.Enabled = true;
                btn_login.Enabled = false;
                textBox_user.Enabled = false;
                textBox_password.Enabled = false;
            }
        }

        private void textBox_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // ENTER
            {
                btn_login.PerformClick();
            }
            else if (e.KeyChar == 27) // ESC
            {
                (sender as TextBox).Text = "";
            }
        }
    }
}

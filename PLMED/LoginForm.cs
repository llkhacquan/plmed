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
    public partial class LoginForm : Form
    {
        private readonly string USER = "";
        private readonly string PASSWORD = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!USER.Equals(textBox_user.Text) || !PASSWORD.Equals(textBox_password.Text))
            {
                MessageBox.Show("Đăng nhập sai!");
                textBox_password.Text = "";
            }
            else
            {
                SelectForm form = new SelectForm();
                Hide();
                form.ShowDialog();
                Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

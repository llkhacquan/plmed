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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void button_customer_Click(object sender, EventArgs e)
        {
            DataForm<Customer> form = new DataForm<Customer>();
            form.loadData(null);
            Hide();
            form.ShowDialog();
            Show();
            form.Dispose();
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            DataForm<Product> form = new DataForm<Product>();
            form.loadData(null);
            Hide();
            form.ShowDialog();
            Show();
            form.Dispose();
        }

        private void button_contract_Click(object sender, EventArgs e)
        {
            DataForm<Contract> form = new DataForm<Contract>();
            form.loadData(null);
            Hide();
            form.ShowDialog();
            Show();
            form.Dispose();
        }

        private void button_report_Click(object sender, EventArgs e)
        {
            ExportForm form = new ExportForm();
            Hide();
            form.ShowDialog();
            Show();
            form.Dispose();
        }

        private void button_staff_Click(object sender, EventArgs e)
        {
            DataForm<Staff> form = new DataForm<Staff>();
            form.loadData(null);
            Hide();
            form.ShowDialog();
            Show();
            form.Dispose();
        }
    }
}

using PLMED.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLMED
{
    internal class IDetailForm : Form
    {
        protected bool editMode;
        protected bool result;
        internal virtual SqlCommand load(Type type, string query)
        {
            throw new NotImplementedException();
        }
        internal virtual Boolean delete(int id)
        {
            throw new NotImplementedException();
        }
        internal virtual Boolean create()
        {
            throw new NotImplementedException();
        }
        internal virtual Boolean update(DataGridViewRow row)
        {
            throw new NotImplementedException();
        }
    }
}

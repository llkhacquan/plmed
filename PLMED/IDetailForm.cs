using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLMED
{
    internal class IDetailForm : Form
    {
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

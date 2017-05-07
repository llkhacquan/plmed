using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLMED
{
    internal abstract class IDetailForm : Form
    {
        internal abstract Boolean delete(int id);
        internal abstract Boolean create();
        internal abstract Boolean update(DataGridViewRow row);
    }
}

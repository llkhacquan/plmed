﻿using System;
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
    internal partial class StaffDetailForm : IDetailForm
    {
        public StaffDetailForm()
        {
            InitializeComponent();
        }

        internal override bool create()
        {
            throw new NotImplementedException();
        }

        internal override bool delete(int id)
        {
            throw new NotImplementedException();
        }

        internal override bool update(DataGridViewRow row)
        {
            throw new NotImplementedException();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISET2020DecouverteWinForm
{
    public partial class EcranApropos : Form
    {
        public EcranApropos()
        {
            InitializeComponent();
        }

        private void btnCloseApropos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

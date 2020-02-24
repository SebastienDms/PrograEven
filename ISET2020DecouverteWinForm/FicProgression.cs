using System;
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
    public partial class EcranProgression : Form
    {
        public EcranProgression()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btExecuter_Click(object sender, EventArgs e)
        {
            int i, j, pas, nbFic;
            Cursor Curseur = Cursor;
            Cursor = Cursors.WaitCursor;
            Random delai = new Random();
            btExecuter.Enabled = btnQuitter.Enabled = false;
            nbFic = 5 + delai.Next(11);
            pbPrincipal.Maximum = nbFic;
            pbPrincipal.Value = 0;
            for(i=0;i<nbFic;i++)
            {
                pbSecondaire.Value = 0;
                pas = 5 + 9 * delai.Next(20);
                for(j=0;j<20;j++)
                {
                    pbSecondaire.Value = (1 + j) * 5;
                    System.Threading.Thread.Sleep(pas);
                }
                pbPrincipal.Value++;
            }

            btExecuter.Enabled = btnQuitter.Enabled = true;
            Cursor = Cursor;
        }
    }
}

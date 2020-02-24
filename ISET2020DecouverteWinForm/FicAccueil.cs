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
    public partial class EcranAccueil : Form
    {
        int i = 1;
        public EcranAccueil()
        {
            InitializeComponent();
        }

        private void btnPousser_Click(object sender, EventArgs e)
        {
            //if(pbDemarrage.Visible) test sur la visibilité de la picturebox \\
            if(i%2==0)
            {
                label1.Text = "Découverte du C#";
                this.pbDemarrage.Image = global::ISET2020DecouverteWinForm.Properties.Resources.High_resolution_wallpaper_background_ID_77701206149;
            }
            else
            {
                label1.Text = "L'autre image";
                this.pbDemarrage.Image = global::ISET2020DecouverteWinForm.Properties.Resources._1428729;
            }
            i++;
        }

        private void EcranAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (MessageBox.Show(this,"Souhaitez-vous quitter la fenêtre", "Votre souhait", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;*/
        }

        private void btnEntrer_Click(object sender, EventArgs e)
        {
            /*
            EcranPrincipal fen = new EcranPrincipal(this);
            fen.Show();
            Hide();
            */
            Close();
        }
    }
}

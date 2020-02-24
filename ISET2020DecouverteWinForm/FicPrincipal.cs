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
    public partial class EcranPrincipal : Form
    {
        public EcranPrincipal()
        {
            InitializeComponent();
        }

        private void EcranPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void NonImplemente(object sender, EventArgs e)
        {
            // MessageBox.Show("A faire");

        }
        private void mpAPropos_Click(object sender, EventArgs e)
        {
            EcranApropos EA = new EcranApropos();
            EA.Show();
        }

        private void mcProgression_Click(object sender, EventArgs e)
        {
            EcranProgression EP = new EcranProgression();
            EP.ShowDialog();
        }

        private void mcListe_Click(object sender, EventArgs e)
        {
            EcranListe EL = new EcranListe();
            EL.ShowDialog();
        }

        private void mApplications_Click(object sender, EventArgs e)
        {

        }

        private void mcEditeur_Click(object sender, EventArgs e)
        {
            EcranEditeur EE = new EcranEditeur();
            EE.ShowDialog();
        }

        private void maSpirographe_Click(object sender, EventArgs e)
        {
            EcranSpirographe ES = new EcranSpirographe();
            ES.ShowDialog();
        }

        private void horlogeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranHorloge EH = new EcranHorloge();
            EH.ShowDialog();
        }

        private void mcClavierSouris_Click(object sender, EventArgs e)
        {
            EcranClavierSouris ECS = new EcranClavierSouris();
            ECS.ShowDialog();
        }

        private void graphiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranGraphique ECG = new EcranGraphique();
            ECG.ShowDialog();
        }
    }
}

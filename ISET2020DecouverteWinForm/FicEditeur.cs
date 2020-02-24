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
    public partial class EcranEditeur : Form
    {
        private bool lModifier;
        private string sFichier;
        public EcranEditeur()
        {
            InitializeComponent();
        }

        private void EcranEditeur_Load(object sender, EventArgs e)
        {
            lModifier = false;
            sFichier = "";
        }
        private void FichierEnregistrer()
        {
            if(sFichier=="")
            {
                if(dEnregistrer.ShowDialog() == DialogResult.OK)
                {
                    sFichier = dEnregistrer.FileName;
                }
            }
            if (sFichier != "")
            {
                rtbTexte.SaveFile(sFichier);
                lModifier = false;
            }
        }
        private void VerifierSauver()
        {
            if(lModifier)
            {
                if(MessageBox.Show("Enregistrer lamise à jour?","Texte modifié...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FichierEnregistrer();
                }
            }
        }

        private void mfNouveau_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            sFichier = "";
            lModifier = false;
            rtbTexte.Clear();

        }

        private void mfOuvrir_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            if(dOuvrir.ShowDialog() == DialogResult.OK)
            {
                sFichier = dOuvrir.FileName;
                rtbTexte.LoadFile(sFichier);
            }
            lModifier = false;
        }

        private void mfEnregistrer_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void mfQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {
            lModifier = true;
        }

        private void meCopier_Click(object sender, EventArgs e)
        {
            rtbTexte.Copy();
        }

        private void meCouper_Click(object sender, EventArgs e)
        {
            rtbTexte.Cut();
        }

        private void meColler_Click(object sender, EventArgs e)
        {
            rtbTexte.Paste();
        }

        private void mfjGauche_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void mfjDroite_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Right;

        }

        private void mfjCentre_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void mfPolice_Click(object sender, EventArgs e)
        {
            if(dPolice.ShowDialog() == DialogResult.OK)
            {
                rtbTexte.SelectionFont = new Font(dPolice.Font, dPolice.Font.Style);
            }
        }

        private void mfcGras_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont.Bold)
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Bold);
            else
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style | FontStyle.Bold);
        }

        private void mfcItalic_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont.Italic)
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Italic);
            else
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style | FontStyle.Italic);
        }

        private void mfcSouligner_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont.Italic)
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Underline);
            else
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style | FontStyle.Underline);
        }

        private void mfcBarrer_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont.Italic)
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Strikeout);
            else
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style | FontStyle.Strikeout);
        }

        private void EcranEditeur_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerifierSauver();
        }
    }
}

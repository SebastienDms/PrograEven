using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace ISET2020DecouverteWinForm
{
    public partial class EcranListe : Form
    {
        private string sFichier = "";
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private const int lbLire = 0x0199;
        private const int lbEcrire = 0x019A;

        public EcranListe()
        {
            InitializeComponent();
        }
        private void Activer(bool lPrincipal)
        {
            lbPersonnes.Enabled = lPrincipal;
            btnOuvrir.Enabled = btnAjouter.Enabled = btnSupprimer.Enabled = btnEnregistrer.Enabled = lPrincipal;
            pDetail.Enabled = !lPrincipal;
        }
        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            Activer(true);// menu ajout désactivé \\

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichiers texte |*.txt|Tous fichiers|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                lbPersonnes.Items.Clear();
                sFichier = ofd.FileName;
                StreamReader sr = new StreamReader(sFichier);
                string sLecture;
                while((sLecture = sr.ReadLine()) != null)
                {
                    string[] aTmp = sLecture.Split('#');
                    int n = lbPersonnes.Items.Add(aTmp[0]);
                    SendMessage(lbPersonnes.Handle, lbEcrire, n, int.Parse(aTmp[1]));
                }
                sr.Close();
                lbFichier.Text = sFichier.Substring(sFichier.LastIndexOf("\\") + 1);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int i = 0, pos_del=0, pos_mod;

            if(lbPersonnes.SelectedIndex >= 0)
            {
                MessageBox.Show(lbPersonnes.SelectedItem.ToString() + " va être supprimé.");
                pos_del = SendMessage(lbPersonnes.Handle, lbLire, lbPersonnes.SelectedIndex, 0);
                lbPersonnes.Items.Remove(lbPersonnes.SelectedItem);
            }
            else
                MessageBox.Show("Plus d'élément dans la liste");

            for(i=0; i<lbPersonnes.Items.Count ;i++)
            {
                pos_mod = SendMessage(lbPersonnes.Handle, lbLire, i, 0);
                if(pos_mod>pos_del)
                {
                    pos_mod--;
                    SendMessage(lbPersonnes.Handle, lbEcrire, i, pos_mod);
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            int n = lbPersonnes.Items.Add(tbNom.Text + " (" + cbQualite.Text + ") ");
            SendMessage(lbPersonnes.Handle, lbEcrire, n, lbPersonnes.Items.Count);
            Activer(true);
        }

        private void lbPersonnes_DoubleClick(object sender, EventArgs e)
        {
            if (lbPersonnes.SelectedIndex >= 0)
            {
                int nPos = SendMessage(lbPersonnes.Handle, lbLire, lbPersonnes.SelectedIndex, 0);
                MessageBox.Show(lbPersonnes.Text + " en posotion " + (1 + lbPersonnes.SelectedIndex).ToString() + " (tri) " 
                    + nPos + " (Encodage) ");
            }
            else
                MessageBox.Show("Pas d'élément sélectionné");
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fichiers texte |*.txt|Tous fichiers|*.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                sFichier = sfd.FileName;
                StreamWriter sw = new StreamWriter(sFichier);
                for(int i=0; i<lbPersonnes.Items.Count; i++)
                {
                    int nPos = SendMessage(lbPersonnes.Handle, lbLire, i, 0);
                    sw.WriteLine(lbPersonnes.Items[i].ToString() + "#" + nPos.ToString());
                }
                sw.Close();
                lbFichier.Text = sFichier.Substring(sFichier.LastIndexOf("\\") + 1);
            }
        }

        private void lbPersonnes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

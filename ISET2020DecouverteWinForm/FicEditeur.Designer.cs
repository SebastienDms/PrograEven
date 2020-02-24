namespace ISET2020DecouverteWinForm
{
    partial class EcranEditeur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mCommandes = new System.Windows.Forms.MenuStrip();
            this.panelCommande = new System.Windows.Forms.Panel();
            this.rtbTexte = new System.Windows.Forms.RichTextBox();
            this.dEnregistrer = new System.Windows.Forms.SaveFileDialog();
            this.dOuvrir = new System.Windows.Forms.OpenFileDialog();
            this.dPolice = new System.Windows.Forms.FontDialog();
            this.mFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mfNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.mfOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mfEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditer = new System.Windows.Forms.ToolStripMenuItem();
            this.meCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.meCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.meColler = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mFormater = new System.Windows.Forms.ToolStripMenuItem();
            this.mfJustufier = new System.Windows.Forms.ToolStripMenuItem();
            this.mfPolice = new System.Windows.Forms.ToolStripMenuItem();
            this.mfCaractere = new System.Windows.Forms.ToolStripMenuItem();
            this.mfjGauche = new System.Windows.Forms.ToolStripMenuItem();
            this.mfjDroite = new System.Windows.Forms.ToolStripMenuItem();
            this.mfjCentre = new System.Windows.Forms.ToolStripMenuItem();
            this.mfcGras = new System.Windows.Forms.ToolStripMenuItem();
            this.mfcItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.mfcSouligner = new System.Windows.Forms.ToolStripMenuItem();
            this.mfcBarrer = new System.Windows.Forms.ToolStripMenuItem();
            this.pbQuitter = new System.Windows.Forms.PictureBox();
            this.pbEnregistrer = new System.Windows.Forms.PictureBox();
            this.pbOuvrir = new System.Windows.Forms.PictureBox();
            this.pbNouveau = new System.Windows.Forms.PictureBox();
            this.mfQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mCommandes.SuspendLayout();
            this.panelCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnregistrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOuvrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNouveau)).BeginInit();
            this.SuspendLayout();
            // 
            // mCommandes
            // 
            this.mCommandes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFichier,
            this.mEditer,
            this.mFormater});
            this.mCommandes.Location = new System.Drawing.Point(0, 0);
            this.mCommandes.Name = "mCommandes";
            this.mCommandes.Size = new System.Drawing.Size(800, 24);
            this.mCommandes.TabIndex = 0;
            this.mCommandes.Text = "menuStrip1";
            // 
            // panelCommande
            // 
            this.panelCommande.Controls.Add(this.pbQuitter);
            this.panelCommande.Controls.Add(this.pbEnregistrer);
            this.panelCommande.Controls.Add(this.pbOuvrir);
            this.panelCommande.Controls.Add(this.pbNouveau);
            this.panelCommande.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCommande.Location = new System.Drawing.Point(0, 24);
            this.panelCommande.Name = "panelCommande";
            this.panelCommande.Size = new System.Drawing.Size(800, 70);
            this.panelCommande.TabIndex = 1;
            // 
            // rtbTexte
            // 
            this.rtbTexte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTexte.Location = new System.Drawing.Point(0, 94);
            this.rtbTexte.Name = "rtbTexte";
            this.rtbTexte.Size = new System.Drawing.Size(800, 356);
            this.rtbTexte.TabIndex = 2;
            this.rtbTexte.Text = "";
            this.rtbTexte.TextChanged += new System.EventHandler(this.rtbTexte_TextChanged);
            // 
            // dEnregistrer
            // 
            this.dEnregistrer.Filter = "Mes Fichiers|*.mesdoc|Tout fichier|*.*";
            // 
            // dOuvrir
            // 
            this.dOuvrir.Filter = "Mes Fichiers|*.mesdoc|Tout fichier|*.*";
            // 
            // mFichier
            // 
            this.mFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mfNouveau,
            this.mfOuvrir,
            this.toolStripMenuItem2,
            this.mfEnregistrer,
            this.mfQuitter});
            this.mFichier.Name = "mFichier";
            this.mFichier.Size = new System.Drawing.Size(54, 20);
            this.mFichier.Text = "Fichier";
            // 
            // mfNouveau
            // 
            this.mfNouveau.Name = "mfNouveau";
            this.mfNouveau.Size = new System.Drawing.Size(180, 22);
            this.mfNouveau.Text = "Nouveau";
            this.mfNouveau.Click += new System.EventHandler(this.mfNouveau_Click);
            // 
            // mfOuvrir
            // 
            this.mfOuvrir.Name = "mfOuvrir";
            this.mfOuvrir.Size = new System.Drawing.Size(180, 22);
            this.mfOuvrir.Text = "Ouvrir";
            this.mfOuvrir.Click += new System.EventHandler(this.mfOuvrir_Click);
            // 
            // mfEnregistrer
            // 
            this.mfEnregistrer.Name = "mfEnregistrer";
            this.mfEnregistrer.Size = new System.Drawing.Size(180, 22);
            this.mfEnregistrer.Text = "Enregistrer";
            this.mfEnregistrer.Click += new System.EventHandler(this.mfEnregistrer_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // mEditer
            // 
            this.mEditer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meCopier,
            this.meCouper,
            this.toolStripMenuItem3,
            this.meColler});
            this.mEditer.Name = "mEditer";
            this.mEditer.Size = new System.Drawing.Size(49, 20);
            this.mEditer.Text = "Editer";
            // 
            // meCopier
            // 
            this.meCopier.Name = "meCopier";
            this.meCopier.Size = new System.Drawing.Size(180, 22);
            this.meCopier.Text = "Copier";
            this.meCopier.Click += new System.EventHandler(this.meCopier_Click);
            // 
            // meCouper
            // 
            this.meCouper.Name = "meCouper";
            this.meCouper.Size = new System.Drawing.Size(180, 22);
            this.meCouper.Text = "Couper";
            this.meCouper.Click += new System.EventHandler(this.meCouper_Click);
            // 
            // meColler
            // 
            this.meColler.Name = "meColler";
            this.meColler.Size = new System.Drawing.Size(180, 22);
            this.meColler.Text = "Coller";
            this.meColler.Click += new System.EventHandler(this.meColler_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(110, 6);
            // 
            // mFormater
            // 
            this.mFormater.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mfJustufier,
            this.mfPolice,
            this.mfCaractere});
            this.mFormater.Name = "mFormater";
            this.mFormater.Size = new System.Drawing.Size(67, 20);
            this.mFormater.Text = "Formater";
            // 
            // mfJustufier
            // 
            this.mfJustufier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mfjGauche,
            this.mfjDroite,
            this.mfjCentre});
            this.mfJustufier.Name = "mfJustufier";
            this.mfJustufier.Size = new System.Drawing.Size(180, 22);
            this.mfJustufier.Text = "Justifier";
            // 
            // mfPolice
            // 
            this.mfPolice.Name = "mfPolice";
            this.mfPolice.Size = new System.Drawing.Size(180, 22);
            this.mfPolice.Text = "Police";
            this.mfPolice.Click += new System.EventHandler(this.mfPolice_Click);
            // 
            // mfCaractere
            // 
            this.mfCaractere.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mfcGras,
            this.mfcItalic,
            this.mfcSouligner,
            this.mfcBarrer});
            this.mfCaractere.Name = "mfCaractere";
            this.mfCaractere.Size = new System.Drawing.Size(180, 22);
            this.mfCaractere.Text = "Caractère";
            // 
            // mfjGauche
            // 
            this.mfjGauche.Name = "mfjGauche";
            this.mfjGauche.Size = new System.Drawing.Size(180, 22);
            this.mfjGauche.Text = "Gauche";
            this.mfjGauche.Click += new System.EventHandler(this.mfjGauche_Click);
            // 
            // mfjDroite
            // 
            this.mfjDroite.Name = "mfjDroite";
            this.mfjDroite.Size = new System.Drawing.Size(180, 22);
            this.mfjDroite.Text = "Droite";
            this.mfjDroite.Click += new System.EventHandler(this.mfjDroite_Click);
            // 
            // mfjCentre
            // 
            this.mfjCentre.Name = "mfjCentre";
            this.mfjCentre.Size = new System.Drawing.Size(180, 22);
            this.mfjCentre.Text = "Centrer";
            this.mfjCentre.Click += new System.EventHandler(this.mfjCentre_Click);
            // 
            // mfcGras
            // 
            this.mfcGras.Name = "mfcGras";
            this.mfcGras.Size = new System.Drawing.Size(180, 22);
            this.mfcGras.Text = "Gras";
            this.mfcGras.Click += new System.EventHandler(this.mfcGras_Click);
            // 
            // mfcItalic
            // 
            this.mfcItalic.Name = "mfcItalic";
            this.mfcItalic.Size = new System.Drawing.Size(180, 22);
            this.mfcItalic.Text = "Italique";
            this.mfcItalic.Click += new System.EventHandler(this.mfcItalic_Click);
            // 
            // mfcSouligner
            // 
            this.mfcSouligner.Name = "mfcSouligner";
            this.mfcSouligner.Size = new System.Drawing.Size(180, 22);
            this.mfcSouligner.Text = "Souligner";
            this.mfcSouligner.Click += new System.EventHandler(this.mfcSouligner_Click);
            // 
            // mfcBarrer
            // 
            this.mfcBarrer.Name = "mfcBarrer";
            this.mfcBarrer.Size = new System.Drawing.Size(180, 22);
            this.mfcBarrer.Text = "Barrer";
            this.mfcBarrer.Click += new System.EventHandler(this.mfcBarrer_Click);
            // 
            // pbQuitter
            // 
            this.pbQuitter.Image = global::ISET2020DecouverteWinForm.Properties.Resources.doorshut;
            this.pbQuitter.Location = new System.Drawing.Point(111, 22);
            this.pbQuitter.Name = "pbQuitter";
            this.pbQuitter.Size = new System.Drawing.Size(27, 27);
            this.pbQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuitter.TabIndex = 6;
            this.pbQuitter.TabStop = false;
            this.pbQuitter.Click += new System.EventHandler(this.mfQuitter_Click);
            // 
            // pbEnregistrer
            // 
            this.pbEnregistrer.Image = global::ISET2020DecouverteWinForm.Properties.Resources.filesave;
            this.pbEnregistrer.Location = new System.Drawing.Point(78, 22);
            this.pbEnregistrer.Name = "pbEnregistrer";
            this.pbEnregistrer.Size = new System.Drawing.Size(27, 27);
            this.pbEnregistrer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnregistrer.TabIndex = 5;
            this.pbEnregistrer.TabStop = false;
            this.pbEnregistrer.Click += new System.EventHandler(this.mfEnregistrer_Click);
            // 
            // pbOuvrir
            // 
            this.pbOuvrir.Image = global::ISET2020DecouverteWinForm.Properties.Resources.fileopen;
            this.pbOuvrir.Location = new System.Drawing.Point(45, 22);
            this.pbOuvrir.Name = "pbOuvrir";
            this.pbOuvrir.Size = new System.Drawing.Size(27, 27);
            this.pbOuvrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOuvrir.TabIndex = 4;
            this.pbOuvrir.TabStop = false;
            this.pbOuvrir.Click += new System.EventHandler(this.mfOuvrir_Click);
            // 
            // pbNouveau
            // 
            this.pbNouveau.Image = global::ISET2020DecouverteWinForm.Properties.Resources.filenew;
            this.pbNouveau.Location = new System.Drawing.Point(12, 22);
            this.pbNouveau.Name = "pbNouveau";
            this.pbNouveau.Size = new System.Drawing.Size(27, 27);
            this.pbNouveau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNouveau.TabIndex = 3;
            this.pbNouveau.TabStop = false;
            this.pbNouveau.Click += new System.EventHandler(this.mfNouveau_Click);
            // 
            // mfQuitter
            // 
            this.mfQuitter.Name = "mfQuitter";
            this.mfQuitter.Size = new System.Drawing.Size(180, 22);
            this.mfQuitter.Text = "Quitter";
            this.mfQuitter.Click += new System.EventHandler(this.mfQuitter_Click);
            // 
            // EcranEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbTexte);
            this.Controls.Add(this.panelCommande);
            this.Controls.Add(this.mCommandes);
            this.MainMenuStrip = this.mCommandes;
            this.Name = "EcranEditeur";
            this.Text = "Traitement de texte modeste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EcranEditeur_FormClosing);
            this.Load += new System.EventHandler(this.EcranEditeur_Load);
            this.mCommandes.ResumeLayout(false);
            this.mCommandes.PerformLayout();
            this.panelCommande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnregistrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOuvrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNouveau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mCommandes;
        private System.Windows.Forms.ToolStripMenuItem mFichier;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mfNouveau;
        private System.Windows.Forms.ToolStripMenuItem mfOuvrir;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mfEnregistrer;
        private System.Windows.Forms.ToolStripMenuItem mEditer;
        private System.Windows.Forms.ToolStripMenuItem meCopier;
        private System.Windows.Forms.ToolStripMenuItem meCouper;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem meColler;
        private System.Windows.Forms.ToolStripMenuItem mFormater;
        private System.Windows.Forms.ToolStripMenuItem mfJustufier;
        private System.Windows.Forms.ToolStripMenuItem mfjGauche;
        private System.Windows.Forms.ToolStripMenuItem mfjDroite;
        private System.Windows.Forms.ToolStripMenuItem mfjCentre;
        private System.Windows.Forms.ToolStripMenuItem mfPolice;
        private System.Windows.Forms.ToolStripMenuItem mfCaractere;
        private System.Windows.Forms.ToolStripMenuItem mfcGras;
        private System.Windows.Forms.ToolStripMenuItem mfcItalic;
        private System.Windows.Forms.ToolStripMenuItem mfcSouligner;
        private System.Windows.Forms.ToolStripMenuItem mfcBarrer;
        private System.Windows.Forms.Panel panelCommande;
        private System.Windows.Forms.RichTextBox rtbTexte;
        private System.Windows.Forms.SaveFileDialog dEnregistrer;
        private System.Windows.Forms.OpenFileDialog dOuvrir;
        private System.Windows.Forms.FontDialog dPolice;
        private System.Windows.Forms.PictureBox pbQuitter;
        private System.Windows.Forms.PictureBox pbEnregistrer;
        private System.Windows.Forms.PictureBox pbOuvrir;
        private System.Windows.Forms.PictureBox pbNouveau;
        private System.Windows.Forms.ToolStripMenuItem mfQuitter;
    }
}
namespace ISET2020DecouverteWinForm
{
    partial class EcranListe
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
            this.lbFichier = new System.Windows.Forms.Label();
            this.lbPersonnes = new System.Windows.Forms.ListBox();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.pDetail = new System.Windows.Forms.Panel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.cbQualite = new System.Windows.Forms.ComboBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbQualite = new System.Windows.Forms.Label();
            this.pDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFichier
            // 
            this.lbFichier.AutoSize = true;
            this.lbFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFichier.Location = new System.Drawing.Point(24, 17);
            this.lbFichier.Name = "lbFichier";
            this.lbFichier.Size = new System.Drawing.Size(113, 17);
            this.lbFichier.TabIndex = 0;
            this.lbFichier.Text = "Nom du fichier";
            // 
            // lbPersonnes
            // 
            this.lbPersonnes.FormattingEnabled = true;
            this.lbPersonnes.Location = new System.Drawing.Point(27, 54);
            this.lbPersonnes.Name = "lbPersonnes";
            this.lbPersonnes.Size = new System.Drawing.Size(641, 173);
            this.lbPersonnes.Sorted = true;
            this.lbPersonnes.TabIndex = 1;
            this.lbPersonnes.DoubleClick += new System.EventHandler(this.lbPersonnes_DoubleClick);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(27, 233);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(75, 23);
            this.btnOuvrir.TabIndex = 2;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(27, 262);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(27, 364);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(27, 393);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.btnAnnuler);
            this.pDetail.Controls.Add(this.btnConfirmer);
            this.pDetail.Controls.Add(this.cbQualite);
            this.pDetail.Controls.Add(this.tbNom);
            this.pDetail.Controls.Add(this.lbNom);
            this.pDetail.Controls.Add(this.lbQualite);
            this.pDetail.Location = new System.Drawing.Point(358, 240);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(200, 209);
            this.pDetail.TabIndex = 6;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(122, 173);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(3, 173);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // cbQualite
            // 
            this.cbQualite.FormattingEnabled = true;
            this.cbQualite.Items.AddRange(new object[] {
            "Madame",
            "Monsieur",
            "Mademoiselle",
            "Autre",
            "Indéfini",
            "Mondamoiseau"});
            this.cbQualite.Location = new System.Drawing.Point(3, 30);
            this.cbQualite.Name = "cbQualite";
            this.cbQualite.Size = new System.Drawing.Size(194, 21);
            this.cbQualite.TabIndex = 1;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(3, 70);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(194, 20);
            this.tbNom.TabIndex = 3;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(10, 54);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(29, 13);
            this.lbNom.TabIndex = 2;
            this.lbNom.Text = "Nom";
            // 
            // lbQualite
            // 
            this.lbQualite.AutoSize = true;
            this.lbQualite.Location = new System.Drawing.Point(10, 14);
            this.lbQualite.Name = "lbQualite";
            this.lbQualite.Size = new System.Drawing.Size(40, 13);
            this.lbQualite.TabIndex = 0;
            this.lbQualite.Text = "Qualité";
            // 
            // EcranListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 461);
            this.Controls.Add(this.pDetail);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.lbPersonnes);
            this.Controls.Add(this.lbFichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranListe";
            this.Text = "Manipulation d\'une liste";
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFichier;
        private System.Windows.Forms.ListBox lbPersonnes;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.ComboBox cbQualite;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbQualite;
    }
}
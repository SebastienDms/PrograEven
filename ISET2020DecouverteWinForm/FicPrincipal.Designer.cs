namespace ISET2020DecouverteWinForm
{
    partial class EcranPrincipal
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.mControle = new System.Windows.Forms.ToolStripMenuItem();
            this.mcProgression = new System.Windows.Forms.ToolStripMenuItem();
            this.mcListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mcEditeur = new System.Windows.Forms.ToolStripMenuItem();
            this.mcClavierSouris = new System.Windows.Forms.ToolStripMenuItem();
            this.mApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.maSpirographe = new System.Windows.Forms.ToolStripMenuItem();
            this.horlogeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.mpAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.graphiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mControle,
            this.mApplications,
            this.mAPropos});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(484, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // mControle
            // 
            this.mControle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcProgression,
            this.mcListe,
            this.mcEditeur,
            this.mcClavierSouris});
            this.mControle.Name = "mControle";
            this.mControle.Size = new System.Drawing.Size(70, 20);
            this.mControle.Text = "Controles";
            // 
            // mcProgression
            // 
            this.mcProgression.Name = "mcProgression";
            this.mcProgression.Size = new System.Drawing.Size(182, 22);
            this.mcProgression.Text = "Barre de progression";
            this.mcProgression.Click += new System.EventHandler(this.mcProgression_Click);
            // 
            // mcListe
            // 
            this.mcListe.Name = "mcListe";
            this.mcListe.Size = new System.Drawing.Size(182, 22);
            this.mcListe.Text = "Liste";
            this.mcListe.Click += new System.EventHandler(this.mcListe_Click);
            // 
            // mcEditeur
            // 
            this.mcEditeur.Name = "mcEditeur";
            this.mcEditeur.Size = new System.Drawing.Size(182, 22);
            this.mcEditeur.Text = "Editeur de texte";
            this.mcEditeur.Click += new System.EventHandler(this.mcEditeur_Click);
            // 
            // mcClavierSouris
            // 
            this.mcClavierSouris.Name = "mcClavierSouris";
            this.mcClavierSouris.Size = new System.Drawing.Size(182, 22);
            this.mcClavierSouris.Text = "Clavier - Souris";
            this.mcClavierSouris.Click += new System.EventHandler(this.mcClavierSouris_Click);
            // 
            // mApplications
            // 
            this.mApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maSpirographe,
            this.horlogeToolStripMenuItem,
            this.graphiqueToolStripMenuItem});
            this.mApplications.Name = "mApplications";
            this.mApplications.Size = new System.Drawing.Size(85, 20);
            this.mApplications.Text = "Applications";
            this.mApplications.Click += new System.EventHandler(this.mApplications_Click);
            // 
            // maSpirographe
            // 
            this.maSpirographe.Name = "maSpirographe";
            this.maSpirographe.Size = new System.Drawing.Size(180, 22);
            this.maSpirographe.Text = "Spirographe";
            this.maSpirographe.Click += new System.EventHandler(this.maSpirographe_Click);
            // 
            // horlogeToolStripMenuItem
            // 
            this.horlogeToolStripMenuItem.Name = "horlogeToolStripMenuItem";
            this.horlogeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horlogeToolStripMenuItem.Text = "Horloge";
            this.horlogeToolStripMenuItem.Click += new System.EventHandler(this.horlogeToolStripMenuItem_Click);
            // 
            // mAPropos
            // 
            this.mAPropos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mpAPropos});
            this.mAPropos.Name = "mAPropos";
            this.mAPropos.Size = new System.Drawing.Size(67, 20);
            this.mAPropos.Text = "A Propos";
            // 
            // mpAPropos
            // 
            this.mpAPropos.Name = "mpAPropos";
            this.mpAPropos.Size = new System.Drawing.Size(122, 22);
            this.mpAPropos.Text = "A propos";
            this.mpAPropos.Click += new System.EventHandler(this.mpAPropos_Click);
            // 
            // graphiqueToolStripMenuItem
            // 
            this.graphiqueToolStripMenuItem.Name = "graphiqueToolStripMenuItem";
            this.graphiqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.graphiqueToolStripMenuItem.Text = "Graphique";
            this.graphiqueToolStripMenuItem.Click += new System.EventHandler(this.graphiqueToolStripMenuItem_Click);
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "EcranPrincipal";
            this.Text = "Manipulation diverses et variées";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EcranPrincipal_FormClosing);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem mControle;
        private System.Windows.Forms.ToolStripMenuItem mcProgression;
        private System.Windows.Forms.ToolStripMenuItem mcListe;
        private System.Windows.Forms.ToolStripMenuItem mcEditeur;
        private System.Windows.Forms.ToolStripMenuItem mApplications;
        private System.Windows.Forms.ToolStripMenuItem mAPropos;
        private System.Windows.Forms.ToolStripMenuItem mpAPropos;
        private System.Windows.Forms.ToolStripMenuItem maSpirographe;
        private System.Windows.Forms.ToolStripMenuItem horlogeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mcClavierSouris;
        private System.Windows.Forms.ToolStripMenuItem graphiqueToolStripMenuItem;
    }
}
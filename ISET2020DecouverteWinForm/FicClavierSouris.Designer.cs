namespace ISET2020DecouverteWinForm
{
    partial class EcranClavierSouris
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
            this.lbClavier = new System.Windows.Forms.ListBox();
            this.btnRaz = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pZoneSouris = new System.Windows.Forms.Panel();
            this.lblGauche = new System.Windows.Forms.Label();
            this.tbGauche = new System.Windows.Forms.TextBox();
            this.tbDroit = new System.Windows.Forms.TextBox();
            this.lblDroit = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbClavier
            // 
            this.lbClavier.FormattingEnabled = true;
            this.lbClavier.Location = new System.Drawing.Point(4, 8);
            this.lbClavier.Name = "lbClavier";
            this.lbClavier.Size = new System.Drawing.Size(237, 173);
            this.lbClavier.TabIndex = 0;
            // 
            // btnRaz
            // 
            this.btnRaz.Location = new System.Drawing.Point(12, 187);
            this.btnRaz.Name = "btnRaz";
            this.btnRaz.Size = new System.Drawing.Size(95, 47);
            this.btnRaz.TabIndex = 1;
            this.btnRaz.Text = "Remise à zéro";
            this.btnRaz.UseVisualStyleBackColor = true;
            this.btnRaz.Click += new System.EventHandler(this.btnRaz_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(129, 187);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(95, 47);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // pZoneSouris
            // 
            this.pZoneSouris.Location = new System.Drawing.Point(268, 51);
            this.pZoneSouris.Name = "pZoneSouris";
            this.pZoneSouris.Size = new System.Drawing.Size(496, 194);
            this.pZoneSouris.TabIndex = 3;
            this.pZoneSouris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pZoneSouris_MouseDown);
            this.pZoneSouris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pZoneSouris_MouseMove);
            // 
            // lblGauche
            // 
            this.lblGauche.AutoSize = true;
            this.lblGauche.Location = new System.Drawing.Point(265, 9);
            this.lblGauche.Name = "lblGauche";
            this.lblGauche.Size = new System.Drawing.Size(77, 13);
            this.lblGauche.TabIndex = 4;
            this.lblGauche.Text = "Clique Gauche";
            // 
            // tbGauche
            // 
            this.tbGauche.Location = new System.Drawing.Point(268, 25);
            this.tbGauche.Name = "tbGauche";
            this.tbGauche.Size = new System.Drawing.Size(100, 20);
            this.tbGauche.TabIndex = 5;
            // 
            // tbDroit
            // 
            this.tbDroit.Location = new System.Drawing.Point(374, 25);
            this.tbDroit.Name = "tbDroit";
            this.tbDroit.Size = new System.Drawing.Size(100, 20);
            this.tbDroit.TabIndex = 7;
            // 
            // lblDroit
            // 
            this.lblDroit.AutoSize = true;
            this.lblDroit.Location = new System.Drawing.Point(371, 9);
            this.lblDroit.Name = "lblDroit";
            this.lblDroit.Size = new System.Drawing.Size(77, 13);
            this.lblDroit.TabIndex = 6;
            this.lblDroit.Text = "Clique Gauche";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(663, 25);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 20);
            this.tbY.TabIndex = 11;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(660, 9);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(54, 13);
            this.lblY.TabIndex = 10;
            this.lblY.Text = "Position Y";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(557, 25);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 20);
            this.tbX.TabIndex = 9;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(554, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(54, 13);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "Position X";
            // 
            // EcranClavierSouris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 257);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.tbDroit);
            this.Controls.Add(this.lblDroit);
            this.Controls.Add(this.tbGauche);
            this.Controls.Add(this.lblGauche);
            this.Controls.Add(this.pZoneSouris);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRaz);
            this.Controls.Add(this.lbClavier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranClavierSouris";
            this.Text = "Suivi du Clavier et de la Souris";
            this.Load += new System.EventHandler(this.EcranClavierSouris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EcranClavierSouris_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbClavier;
        private System.Windows.Forms.Button btnRaz;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel pZoneSouris;
        private System.Windows.Forms.Label lblGauche;
        private System.Windows.Forms.TextBox tbGauche;
        private System.Windows.Forms.TextBox tbDroit;
        private System.Windows.Forms.Label lblDroit;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label lblX;
    }
}
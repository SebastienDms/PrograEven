namespace ISET2020DecouverteWinForm
{
    partial class EcranSpirographe
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
            this.gbParametres = new System.Windows.Forms.GroupBox();
            this.btnFond = new System.Windows.Forms.Button();
            this.btnTrait = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbProfondeur = new System.Windows.Forms.TrackBar();
            this.lblProfondeur = new System.Windows.Forms.Label();
            this.tbDensite = new System.Windows.Forms.TrackBar();
            this.lblDensite = new System.Windows.Forms.Label();
            this.tbSommets = new System.Windows.Forms.TrackBar();
            this.lblSommets = new System.Windows.Forms.Label();
            this.dCouleurs = new System.Windows.Forms.ColorDialog();
            this.gbParametres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSommets)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametres
            // 
            this.gbParametres.Controls.Add(this.btnFond);
            this.gbParametres.Controls.Add(this.btnTrait);
            this.gbParametres.Controls.Add(this.btnGo);
            this.gbParametres.Controls.Add(this.tbProfondeur);
            this.gbParametres.Controls.Add(this.lblProfondeur);
            this.gbParametres.Controls.Add(this.tbDensite);
            this.gbParametres.Controls.Add(this.lblDensite);
            this.gbParametres.Controls.Add(this.tbSommets);
            this.gbParametres.Controls.Add(this.lblSommets);
            this.gbParametres.Location = new System.Drawing.Point(12, 12);
            this.gbParametres.Name = "gbParametres";
            this.gbParametres.Size = new System.Drawing.Size(232, 321);
            this.gbParametres.TabIndex = 0;
            this.gbParametres.TabStop = false;
            this.gbParametres.Text = "Paramètres";
            // 
            // btnFond
            // 
            this.btnFond.Image = global::ISET2020DecouverteWinForm.Properties.Resources.ICFond;
            this.btnFond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFond.Location = new System.Drawing.Point(33, 280);
            this.btnFond.Name = "btnFond";
            this.btnFond.Size = new System.Drawing.Size(75, 23);
            this.btnFond.TabIndex = 9;
            this.btnFond.Text = "Fond";
            this.btnFond.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFond.UseVisualStyleBackColor = true;
            this.btnFond.Click += new System.EventHandler(this.btnFond_Click);
            // 
            // btnTrait
            // 
            this.btnTrait.Image = global::ISET2020DecouverteWinForm.Properties.Resources.ICTrait;
            this.btnTrait.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrait.Location = new System.Drawing.Point(33, 251);
            this.btnTrait.Name = "btnTrait";
            this.btnTrait.Size = new System.Drawing.Size(75, 23);
            this.btnTrait.TabIndex = 8;
            this.btnTrait.Text = "Trait";
            this.btnTrait.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrait.UseVisualStyleBackColor = true;
            this.btnTrait.Click += new System.EventHandler(this.btnTrait_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(33, 222);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "G O";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbProfondeur
            // 
            this.tbProfondeur.Location = new System.Drawing.Point(3, 147);
            this.tbProfondeur.Maximum = 80;
            this.tbProfondeur.Minimum = 20;
            this.tbProfondeur.Name = "tbProfondeur";
            this.tbProfondeur.Size = new System.Drawing.Size(226, 45);
            this.tbProfondeur.TabIndex = 6;
            this.tbProfondeur.TickFrequency = 5;
            this.tbProfondeur.Value = 40;
            // 
            // lblProfondeur
            // 
            this.lblProfondeur.AutoSize = true;
            this.lblProfondeur.Location = new System.Drawing.Point(6, 131);
            this.lblProfondeur.Name = "lblProfondeur";
            this.lblProfondeur.Size = new System.Drawing.Size(152, 13);
            this.lblProfondeur.TabIndex = 5;
            this.lblProfondeur.Text = "Profondeur de dessin (20 à 80)";
            // 
            // tbDensite
            // 
            this.tbDensite.Location = new System.Drawing.Point(3, 83);
            this.tbDensite.Maximum = 20;
            this.tbDensite.Minimum = 5;
            this.tbDensite.Name = "tbDensite";
            this.tbDensite.Size = new System.Drawing.Size(226, 45);
            this.tbDensite.TabIndex = 4;
            this.tbDensite.Value = 10;
            // 
            // lblDensite
            // 
            this.lblDensite.AutoSize = true;
            this.lblDensite.Location = new System.Drawing.Point(9, 64);
            this.lblDensite.Name = "lblDensite";
            this.lblDensite.Size = new System.Drawing.Size(130, 13);
            this.lblDensite.TabIndex = 3;
            this.lblDensite.Text = "Densite de dessin (5 à 20)";
            // 
            // tbSommets
            // 
            this.tbSommets.Location = new System.Drawing.Point(0, 32);
            this.tbSommets.Maximum = 8;
            this.tbSommets.Minimum = 3;
            this.tbSommets.Name = "tbSommets";
            this.tbSommets.Size = new System.Drawing.Size(226, 45);
            this.tbSommets.TabIndex = 2;
            this.tbSommets.Value = 5;
            // 
            // lblSommets
            // 
            this.lblSommets.AutoSize = true;
            this.lblSommets.Location = new System.Drawing.Point(6, 16);
            this.lblSommets.Name = "lblSommets";
            this.lblSommets.Size = new System.Drawing.Size(138, 13);
            this.lblSommets.TabIndex = 1;
            this.lblSommets.Text = "Nombre de Sommets (3 à 8)";
            // 
            // EcranSpirographe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 345);
            this.Controls.Add(this.gbParametres);
            this.MinimumSize = new System.Drawing.Size(384, 384);
            this.Name = "EcranSpirographe";
            this.Text = "Spirographe";
            this.Load += new System.EventHandler(this.EcranSpirographe_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EcranSpirographe_Paint);
            this.gbParametres.ResumeLayout(false);
            this.gbParametres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSommets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametres;
        private System.Windows.Forms.TrackBar tbProfondeur;
        private System.Windows.Forms.Label lblProfondeur;
        private System.Windows.Forms.TrackBar tbDensite;
        private System.Windows.Forms.Label lblDensite;
        private System.Windows.Forms.TrackBar tbSommets;
        private System.Windows.Forms.Label lblSommets;
        private System.Windows.Forms.Button btnFond;
        private System.Windows.Forms.Button btnTrait;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ColorDialog dCouleurs;
    }
}
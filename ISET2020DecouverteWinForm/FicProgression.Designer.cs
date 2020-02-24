namespace ISET2020DecouverteWinForm
{
    partial class EcranProgression
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
            this.lbPrincipal = new System.Windows.Forms.Label();
            this.pbPrincipal = new System.Windows.Forms.ProgressBar();
            this.pbSecondaire = new System.Windows.Forms.ProgressBar();
            this.lbSecondaire = new System.Windows.Forms.Label();
            this.btExecuter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPrincipal
            // 
            this.lbPrincipal.AutoSize = true;
            this.lbPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPrincipal.Location = new System.Drawing.Point(12, 9);
            this.lbPrincipal.Name = "lbPrincipal";
            this.lbPrincipal.Size = new System.Drawing.Size(108, 18);
            this.lbPrincipal.TabIndex = 0;
            this.lbPrincipal.Text = "Copie (globale)";
            // 
            // pbPrincipal
            // 
            this.pbPrincipal.Location = new System.Drawing.Point(12, 30);
            this.pbPrincipal.Name = "pbPrincipal";
            this.pbPrincipal.Size = new System.Drawing.Size(260, 23);
            this.pbPrincipal.Step = 1;
            this.pbPrincipal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPrincipal.TabIndex = 1;
            // 
            // pbSecondaire
            // 
            this.pbSecondaire.Location = new System.Drawing.Point(12, 129);
            this.pbSecondaire.Name = "pbSecondaire";
            this.pbSecondaire.Size = new System.Drawing.Size(260, 23);
            this.pbSecondaire.Step = 1;
            this.pbSecondaire.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSecondaire.TabIndex = 3;
            // 
            // lbSecondaire
            // 
            this.lbSecondaire.AutoSize = true;
            this.lbSecondaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecondaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSecondaire.Location = new System.Drawing.Point(12, 108);
            this.lbSecondaire.Name = "lbSecondaire";
            this.lbSecondaire.Size = new System.Drawing.Size(100, 18);
            this.lbSecondaire.TabIndex = 2;
            this.lbSecondaire.Text = "Copie (fichier)";
            // 
            // btExecuter
            // 
            this.btExecuter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExecuter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btExecuter.Location = new System.Drawing.Point(42, 212);
            this.btExecuter.Name = "btExecuter";
            this.btExecuter.Size = new System.Drawing.Size(75, 40);
            this.btExecuter.TabIndex = 4;
            this.btExecuter.Text = "Executer";
            this.btExecuter.UseVisualStyleBackColor = true;
            this.btExecuter.Click += new System.EventHandler(this.btExecuter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(160, 212);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 40);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // EcranProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btExecuter);
            this.Controls.Add(this.pbSecondaire);
            this.Controls.Add(this.lbSecondaire);
            this.Controls.Add(this.pbPrincipal);
            this.Controls.Add(this.lbPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranProgression";
            this.Text = "Barre de progression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrincipal;
        private System.Windows.Forms.ProgressBar pbPrincipal;
        private System.Windows.Forms.ProgressBar pbSecondaire;
        private System.Windows.Forms.Label lbSecondaire;
        private System.Windows.Forms.Button btExecuter;
        private System.Windows.Forms.Button btnQuitter;
    }
}
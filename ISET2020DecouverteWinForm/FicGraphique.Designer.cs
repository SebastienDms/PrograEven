using System;
using System.Windows.Forms;

namespace ISET2020DecouverteWinForm
{
    partial class EcranGraphique
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
            this.btnCreerGraphique = new System.Windows.Forms.Button();
            this.pbGraphique = new System.Windows.Forms.PictureBox();
            this.lbPointsGraphique = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphique)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreerGraphique
            // 
            this.btnCreerGraphique.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreerGraphique.Location = new System.Drawing.Point(0, 0);
            this.btnCreerGraphique.Name = "btnCreerGraphique";
            this.btnCreerGraphique.Size = new System.Drawing.Size(884, 31);
            this.btnCreerGraphique.TabIndex = 0;
            this.btnCreerGraphique.Text = "Générer le graphique";
            this.btnCreerGraphique.UseVisualStyleBackColor = true;
            this.btnCreerGraphique.Click += new System.EventHandler(this.btnCreerGraphique_Click);
            // 
            // pbGraphique
            // 
            this.pbGraphique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGraphique.Location = new System.Drawing.Point(0, 31);
            this.pbGraphique.Name = "pbGraphique";
            this.pbGraphique.Size = new System.Drawing.Size(884, 430);
            this.pbGraphique.TabIndex = 1;
            this.pbGraphique.TabStop = false;
            this.pbGraphique.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGraphique_Paint);
            // 
            // lbPointsGraphique
            // 
            this.lbPointsGraphique.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbPointsGraphique.FormattingEnabled = true;
            this.lbPointsGraphique.Location = new System.Drawing.Point(764, 31);
            this.lbPointsGraphique.Name = "lbPointsGraphique";
            this.lbPointsGraphique.Size = new System.Drawing.Size(120, 430);
            this.lbPointsGraphique.TabIndex = 2;
            // 
            // EcranGraphique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.lbPointsGraphique);
            this.Controls.Add(this.pbGraphique);
            this.Controls.Add(this.btnCreerGraphique);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranGraphique";
            this.Text = "Graphique";
            this.Load += new System.EventHandler(this.EcranGraphique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphique)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreerGraphique;
        private System.Windows.Forms.PictureBox pbGraphique;
        private ListBox lbPointsGraphique;
    }
}
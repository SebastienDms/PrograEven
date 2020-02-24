namespace ISET2020DecouverteWinForm
{
    partial class EcranHorloge
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
            this.components = new System.ComponentModel.Container();
            this.tmHorloge = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmHorloge
            // 
            this.tmHorloge.Interval = 1000;
            this.tmHorloge.Tick += new System.EventHandler(this.tmHorloge_Tick);
            // 
            // EcranHorloge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Name = "EcranHorloge";
            this.Text = "Horloge made in moi";
            this.Load += new System.EventHandler(this.EcranHorloge_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EcranHorloge_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmHorloge;
    }
}
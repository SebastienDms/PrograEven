using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Diagnostics;


namespace ISET2020DecouverteWinForm
{
    public partial class EcranHorloge : Form
    {
        int j = 0;
        private GraphicsPath DessinSauve;
        List<Rectangle> lRect = new List<Rectangle>();
        public EcranHorloge()
        {
            InitializeComponent();
        }

        private void EcranHorloge_Load(object sender, EventArgs e)
        {
            tmHorloge.Enabled = true;
        }

        private void EcranHorloge_Paint(object sender, PaintEventArgs e)
        {
            
            int nbSommets = 12, cerc_sec=nbSommets*5;
            int xc = ClientSize.Width / 2;
            int yc = ClientSize.Height / 2;
            int rayon = ClientSize.Height/2 - 11;
            DessinSauve = new GraphicsPath();

            int[] sX = new int[nbSommets + 1];
            int[] sY = new int[nbSommets + 1];
            for (int i = 0; i < nbSommets; i++)
            {
                sX[i] = (int)(xc + rayon * Math.Cos(i * 2 * Math.PI / nbSommets));
                sY[i] = (int)(yc + rayon * Math.Sin(i * 2 * Math.PI / nbSommets));
            }

            int x, y;
            for(int i=0; i<= nbSommets; i++)
            {
                x = sX[i];
                y = sY[i];
                e.Graphics.FillEllipse(new SolidBrush(Color.Green), x, y, 5, 5);
                DessinSauve.AddEllipse(x, y, 5, 5);
            }

            int[] cX = new int[cerc_sec];
            int[] cY = new int[cerc_sec];
            for (int i = 0; i < cerc_sec; i++)
            {
                cX[i] = (int)(xc + rayon * Math.Cos(i * 2 * Math.PI / cerc_sec));
                cY[i] = (int)(yc + rayon * Math.Sin(i * 2 * Math.PI / cerc_sec));
            }

            Rectangle r = new Rectangle(new Point(0, 0), ClientSize);
            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), r);
            e.Graphics.DrawPath(new Pen(Color.Green), DessinSauve);
            e.Graphics.DrawLine(new Pen(Color.Red, 3), xc, yc, cX[j], cY[j]);
            /*e.Graphics.DrawLine(new Pen(Color.Blue, 3), xc, yc, sX[k] - 20, sY[k]);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), xc, yc, sX[l] - 70, sY[l]);*/
            j++;
            if (j == cerc_sec)
            {
                j = 0;

            }
        }

        private void tmHorloge_Tick(object sender, EventArgs e)
        {
            DateTime Temp = DateTime.Now;
            
            Invalidate();
        }
    }
}

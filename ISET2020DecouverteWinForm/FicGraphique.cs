using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ISET2020DecouverteWinForm
{
    public partial class EcranGraphique : Form
    {
        Color trait;
        private Graphique graphique1;
        private GraphicsPath dessinsauve;
        private int hauteur, largeur;
        private float y_max_haut = 0;
        private float y_max_bas = 0;
        private float indice_zoom_y = 0;
        private float indice_zoom_x = 0;
        private float x_max_gauche = 0;
        private float x_max_droite = 0;


        internal Graphique Graphique1 { get => graphique1; set => graphique1 = value; }

        public EcranGraphique()
        {
            InitializeComponent();
        }

        private void btnCreerGraphique_Click(object sender, EventArgs e)
        {
            //hauteur = pbGraphique.Height/2;
            //largeur = pbGraphique.Width;
            int nb_points = 0, x = 0, y = 0;
            Random random = new Random();
            Graphique1 = new Graphique();
            dessinsauve = new GraphicsPath();
            trait = Color.Blue;

            // Nombre de point aleatoire entre 2 (pour former min une ligne) et 20
            nb_points = random.Next(2, 20);
            // Creation du dessin graphique
            for (int i = 0; i < nb_points; i++)
            {
                x = random.Next(x + 1, x + 50);
                y = random.Next(-100, 100);
                Graphique1.AjoutPoint(x, y);
            }

            lbPointsGraphique.Items.Clear();
            foreach (var point in Graphique1.Dessin)
            {
                lbPointsGraphique.Items.Add("X : " + point.X + " Y : " + -point.Y);
            }

            Pointgraphique[] pointsGraphique = new Pointgraphique[Graphique1.Dessin.Count];
            Graphique1.Dessin.CopyTo(pointsGraphique);
            //recherche des X max gauche et droite et des Y max haut et bas
            DeltaMaxX(Graphique1.Dessin);
            DeltaMaxY(Graphique1.Dessin);
            //translation du dessin vers la picturebox
            Translation(Graphique1.Dessin);
            //Adaptation du graphique à la PBGraphique
            Zoom(Graphique1.Dessin);

            for (int i = 0; i < nb_points - 1; i++)
            {
                dessinsauve.AddLine(Graphique1.Dessin[i].X, Graphique1.Dessin[i].Y, Graphique1.Dessin[i + 1].X, Graphique1.Dessin[i + 1].Y);
                dessinsauve.AddEllipse(Graphique1.Dessin[i].X - 1, Graphique1.Dessin[i].Y -1, 2, 2);
            }

            pbGraphique.Invalidate(false);
        }

        private void EcranGraphique_Load(object sender, EventArgs e)
        {

        }

        private void pbGraphique_Paint(object sender, PaintEventArgs e)
        {
            if (dessinsauve != null)
            {
                e.Graphics.DrawLine(new Pen(Color.Red, 2), 0, (0 - y_max_bas) * indice_zoom_y,
                    pbGraphique.Width * indice_zoom_x, (0 - y_max_bas) * indice_zoom_y);
                e.Graphics.DrawPath(new Pen(trait, 4), dessinsauve);
            }
        }
        private void DeltaMaxY(List<Pointgraphique> points_dessin)
        {
            foreach(Pointgraphique point in points_dessin)
            {
                if (point.Y >= y_max_haut)
                    y_max_haut = (int)point.Y;
                if (point.Y <= y_max_bas)
                    y_max_bas = (int)point.Y;
            }
            indice_zoom_y = pbGraphique.Height / (y_max_haut - y_max_bas);
        }
        private void DeltaMaxX(List<Pointgraphique> points_dessin)
        {
            x_max_gauche = points_dessin[0].X;
            x_max_droite = points_dessin[points_dessin.Count() - 1].X;

            indice_zoom_x = pbGraphique.Width / (x_max_droite - x_max_gauche);
        }

        private void Translation(List<Pointgraphique> points_dessin)
        {
            foreach (Pointgraphique point in points_dessin)
            {
                point.X = point.X - x_max_gauche;
                point.Y = point.Y - y_max_bas;
            }
        }

        private void Zoom(List<Pointgraphique> points_dessin)
        {
            foreach (Pointgraphique point in points_dessin)
            {
                point.X = point.X * indice_zoom_x * (float)0.98;
                point.Y = point.Y * indice_zoom_y * (float)0.98;
                // * 0.95 pour ne pas coller les points extrèmes au limite de la PB \\
            }
        }
    }
}

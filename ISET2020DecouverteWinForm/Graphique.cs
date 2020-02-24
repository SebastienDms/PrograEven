using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISET2020DecouverteWinForm
{
    class Graphique
    {
        private List<Pointgraphique> dessin;

        internal List<Pointgraphique> Dessin { get => dessin; set => dessin = value; }

        public Graphique()
        {
            // Creation de la liste de point(s)
            Dessin = new List<Pointgraphique>();
            //Pointgraphique point = new Pointgraphique(0, 0);
        }

        public void AjoutPoint(float x, float y)
        {
            // Creation d'un point
            // -y car graphiquement le y est opposé au graphique mathématique
            Pointgraphique point = new Pointgraphique(x, -y);

            // On vérifie si le point repond bien aux contraintes posees par le problème
            if (VerifieContraintes(point))
                // Ajout du point à la liste ( donc au dessin)
                Dessin.Add(point);
            else
                MessageBox.Show("Point non ajouté...");

        }

        public bool VerifieContraintes(Pointgraphique point_a_verif)
        {
            int nb_elem = Dessin.Count;
            if (point_a_verif.Y < -100 || point_a_verif.Y > 100)
            {
                return false;
            }
            if (nb_elem > 0)
            {
                if (point_a_verif.X <= Dessin[nb_elem - 1].X)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

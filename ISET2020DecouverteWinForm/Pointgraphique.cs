using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISET2020DecouverteWinForm
{
    class Pointgraphique
    {
        private float x, y;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public Pointgraphique(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}

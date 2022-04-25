using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Qudditch
{
    class Snitch
    {
        private int speed = 15;
        Random rng = new Random();
        private Image picture;
        private int[] direction = { 1, 2, 3, 4, 0 };
        private bool movement;
        
        public void Get_Direction()
        {
            int n = rng.Next(0, 4);
            

            switch (n)
            {
                case 0:
                    movement = false;
                    break;
                case 1:
                    movement = true;
                    break;
            }
        }

        public Snitch(int n, Image P)
        {
            speed = n;
            picture = P;
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public Image Picture
        {
            get { return picture; }
            set { picture = value; }
        }
    }
}

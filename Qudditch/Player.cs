using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Qudditch
{
    class Player
    {
        private int speed = 10;
        private Image picture;

        public Player(int n, Image P)
        {
            speed = n ;
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

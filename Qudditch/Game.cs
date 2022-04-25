using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qudditch
{
    class Game
    {
        private int count = 0;
        private int posX1;
        private int posY1;
        private int posX2;
        private int posY2;

        private void Game1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                posX1 -= 5;
                return;
            }
            if (e.KeyCode == Keys.D)
            {
                posX1 += 5;
                return;
            }
            if (e.KeyCode == Keys.W)
            {
                posY1 -= 5;
                return;
            }
            if (e.KeyCode == Keys.S)
            {
                posY1 += 5;
                return;
            }
        }

        private void Game2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                posX2 -= 5;
                return;
            }
            if (e.KeyCode == Keys.Right)
            {
                posX2 += 5;
                return;
            }
            if (e.KeyCode == Keys.Up)
            {
                posY2 -= 5;
                return;
            }
            if (e.KeyCode == Keys.Down)
            {
                posY2 += 5;
                return;
            }
        }
    }
}

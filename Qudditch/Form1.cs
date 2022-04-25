using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qudditch
{
    public partial class Form1 : Form
    {
        Player player1;
        Player player2;
        Snitch snitch0;
        int count = 0;
        private int posX1 = 100;
        private int posY1 = 300;
        private int posX2 = 400;
        private int posY2 = 300;
        bool BposX1;
        bool BposX2;
        bool BposX3;
        bool BposX4;
        bool BposY1;
        bool BposY2;
        bool BposY3;
        bool BposY4;
        int posX;
        int posY;
        Random rngX = new Random();
        Random rngY = new Random();
        int RposX;
        int RposY;

        public Form1()
        {
            InitializeComponent();
            posX = snitch.Location.X;
            posY = snitch.Location.Y;
            RposX = rngX.Next(0, this.Width);
            RposY = rngY.Next(0, this.Height);
        }

        private void Harry_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BposX1 == true)
            {
                posX1 -= 2;
            }
            if (BposX2 == true)
            {
                posX1 += 2;
            }
            if (BposY1 == true)
            {
                posY1 -= 2;
            }
            if (BposY2 == true)
            {
                posY1 += 2;
            }

            if (BposX3 == true)
            {
                posX2 -= 2;
            }
            if (BposX4 == true)
            {
                posX2 += 2;
            }
            if (BposY3 == true)
            {
                posY2 -= 2;
            }
            if (BposY4 == true)
            {
                posY2 += 2;
            }

            Harry.Location = new Point(posX1, posY1);
            Draco.Location = new Point(posX2, posY2);
        }

        private void Game1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                BposX1 = true;
                return;
            }
            if (e.KeyCode == Keys.D)
            {
                BposX2 = true;
                return;
            }
            if (e.KeyCode == Keys.W)
            {
                BposY1 = true;
                return;
            }
            if (e.KeyCode == Keys.S)
            {
                BposY2 = true;
                return;
            }
            if (e.KeyCode == Keys.Left)
            {
                BposX3 = true;
                return;
            }
            if (e.KeyCode == Keys.Right)
            {
                BposX4 = true;
                return;
            }
            if (e.KeyCode == Keys.Up)
            {
                BposY3 = true;
                return;
            }
            if (e.KeyCode == Keys.Down)
            {
                BposY4 = true;
                return;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count++;

            if (count == 100)
            {
                RposX = rngX.Next(0, this.Width);
                RposY = rngY.Next(0, this.Height);
                count = 0;
            }

            if (posX != RposX)
            {
                if (posX < RposX)
                {
                    posX += 2;
                }
                if (posX > RposX)
                {
                    posX -= 2;
                }
            }
            if (posY != RposY)
            {
                if (posY < RposY)
                {
                    posY += 2;
                }
                if (posY > RposY)
                {
                    posY -= 2;
                }
            }
            if (posX == RposX & posY == RposY)
            {
                RposX = rngX.Next(0, this.Width);
                RposY = rngY.Next(0, this.Height);
            }
            else if (posX + RposX > this.Width)
            {
                RposX = rngX.Next(0, this.Width);
            }
            else if (posY + RposY > this.Height)
            {
                RposY = rngY.Next(0, this.Height);
            }

            snitch.Location = new Point(posX, posY);

            if (snitch.Bounds.IntersectsWith(Harry.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Harry WINS");
            }
            if (snitch.Bounds.IntersectsWith(Draco.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Draco WINS");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BposX1 = false;
            BposY1 = false;
            BposX2 = false;
            BposY2 = false;
            BposX3 = false;
            BposY3 = false;
            BposX4 = false;
            BposY4 = false;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                BposX1 = false;
                return;
            }
            if (e.KeyCode == Keys.D)
            {
                BposX2 = false;
                return;
            }
            if (e.KeyCode == Keys.W)
            {
                BposY1 = false;
                return;
            }
            if (e.KeyCode == Keys.S)
            {
                BposY2 = false;
                return;
            }
            if (e.KeyCode == Keys.Left)
            {
                BposX3 = false;
                return;
            }
            if (e.KeyCode == Keys.Right)
            {
                BposX4 = false;
                return;
            }
            if (e.KeyCode == Keys.Up)
            {
                BposY3 = false;
                return;
            }
            if (e.KeyCode == Keys.Down)
            {
                BposY4 = false;
                return;
            }
        }
    }
}

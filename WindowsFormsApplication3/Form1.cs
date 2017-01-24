using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {

        int xSpeed = 0;
        int ySpeed = 0;
        int xAccelLimit = 21;
        int yAccelLimit = 21;
        int acceleration = 1;



        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pbMove.Left += xSpeed;
            pbMove.Top += ySpeed;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D)
            {
                if(xSpeed<=xAccelLimit)
                {
                    xSpeed += acceleration;
                }
            }

            if (e.KeyCode == Keys.A)
            {
                if (xSpeed >= -xAccelLimit)
                {
                    xSpeed -= acceleration;
                }

            }

            if (e.KeyCode == Keys.S)
            {
                if (ySpeed <= yAccelLimit)
                {
                    ySpeed += acceleration;
                }
            }

            if (e.KeyCode == Keys.W)
            {
                if (ySpeed >= -yAccelLimit)
                {
                    ySpeed -= acceleration;
                }
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

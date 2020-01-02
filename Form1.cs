using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Snake snake = new Snake();
        public Form1()
        {
            

            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            snake.drawSnake(graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}

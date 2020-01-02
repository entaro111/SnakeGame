using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    class Snake
    {

        public Rectangle[] snakeParts;
        private SolidBrush brush;
        private int x, y, width, height;

        public Snake()
        {
            snakeParts = new Rectangle[3];
            brush = new SolidBrush(Color.DarkViolet);

            x = 100;
            y = 0;
            width = 20;
            height = 20;

            for (int i = 0; i < snakeParts.Length; i++)
            {
                snakeParts[i] = new Rectangle(x, y, width, height);
                x -= 20;
            }

        }

        public void drawSnake(Graphics graphics)
        {
            foreach(Rectangle rectangle in snakeParts)
            {
                graphics.FillRectangle(brush, rectangle);
            }
        }


    }
}

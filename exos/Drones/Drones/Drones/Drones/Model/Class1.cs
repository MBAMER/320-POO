using System.Drawing;

namespace building
{
    public class Building
    {
        // Attributs du bâtiment
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public Color Color { get; set; }

        // Constructeur
        public Building(int x, int y, int width, int depth, Color color)
        {
            X = x;
            Y = y;
            Width = width;
            Depth = depth;
            Color = color;
        }

        // Méthode pour dessiner le bâtiment
        public void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, X, Y, Width, Depth);
            }


        }
    }
}

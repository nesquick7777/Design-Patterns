using System.IO;

namespace ColorPrototype
{
    internal static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
           List<Color> colors = new List<Color>() { new Color(0, 0, 0), new Color(255, 255, 255), new Color(0, 255, 0) };
            
            List<ColorPrototype> colorsPrototype = new List<ColorPrototype>();

            foreach (var color in colors)
            {
                colorsPrototype.Add(color);
                Console.WriteLine(color);

            }

            ColorPalette palette = new ColorPalette();
            palette["White"]=new Color(0,0,0);
            ColorPrototype white = palette["White"];
            Console.WriteLine(white);
            Console.WriteLine(palette["White"]);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Forest
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        private List<TreeSpecies> trees = new List<TreeSpecies>();
        public Forest(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public void PlantTree(int x, int y, String name, String color, String texture)
        {
            TreeSpecies type = TreeFactory.GetTreeType(name, color, texture);
            TreeSpecies tree = new Tree(x, y, type);
            trees.Add(tree);
        }
    }
}

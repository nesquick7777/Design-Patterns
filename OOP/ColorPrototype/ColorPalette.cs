using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPrototype
{
    internal class ColorPalette
    {
        private Dictionary<string, ColorPrototype> prototypes = new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get { return prototypes[key].Clone(); }
            set { prototypes.Add(key, value); }
        }

    }
}

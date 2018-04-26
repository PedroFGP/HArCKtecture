using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HArCKtecture.Classes
{
    public static class UniqueColorGenerator
    {
        private static Random Rnd = new Random();

        public static Color Next()
        {
            return Color.FromArgb(255, Rnd.Next(0, 256), Rnd.Next(0, 256), Rnd.Next(0, 256));
        }
    }
}

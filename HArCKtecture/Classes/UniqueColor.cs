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
        private static int ColorIndex = 0;
        private static readonly int OFFSET_INCREMENT = 5000;

        public static Color Next()
        {
            ColorIndex += OFFSET_INCREMENT;

            return Color.FromArgb(255, Color.FromArgb(ColorIndex));
        }
    }
}

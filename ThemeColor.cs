using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUEXEOTO
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }

        public static List<string> ColorList = new List<string>(){
            "#FEE0C0", "#FF7C7C", "#B9005B", "#820000", "#54BAB9", "#9ED2C6", "#E9DAC1", "#FFE898", "#FF87B2", "#F65A83", "#C1EFFF", "#FFB3B3", "#FFDBA4", "#3120E0", "#3B9AE1", "#21E1E1", "#F0EABE", "#A10035", "#FEC260", "#3FA796", "#2A0944", "#8FE3CF", "#256D85", "#9C9EFE", "#A66CFF", "#FA2FB5", "#2B7A0B", "#5BB318", "#7DCE13", "#3CCF4E", "#EB4747", "#FF8B8B", "#FFDEDE", "#3330E4", "#937DC2", "#C689C6", "#610C63", "#810955", "#FFF9D7", "#F2D7D9", "#D3CEDF", "#76BA99", "#ADCF9F", "#CED89E", "#F4E06D", "#F7EC09", "#3EC70B", "#3AB0FF", "#CDF0EA", "#F15412", "#1F4690"
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}

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
            "#A8E6CF", "#DCEDC1", "#FFD3B6", "#FFAAA5", "#CCF6C8", "#FAFCC2", "#F6D6AD", "#F9C0C0", "#75CFB8", "#BBDFC8", "#F0E5D8", "#FFC478", "#28DF99", "#99F3BD", "#D2F6C5", "#F6F7D4", "#FFB6B9", "#FAE3D9", "#BBDED6", "#8AC6D1", "#98DDCA", "#D5ECC2", "#FFD3B4", "#FFAAA7", "#40DFEF", "#B9F8D3", "#FFFBE7", "#E78EA9", "#F5F0BB", "#C4DFAA", "#90C8AC", "#73A9AD", "#FFE6E6", "#F2D1D1", "#DAEAF1", "#C6DCE4", "#FCF8E8", "#94B49F", "#ECB390", "#DF7861", "#FFF9CA", "#FFDEB4", "#FFB4B4", "#B2A4FF", "#377D71", "#FBC5C5", "#FBA1A1", "#8879B0", "#F9CEEE", "#F9F3EE", "#CCF3EE", "#97C4B8", "#DFBB9D", "#F7E2D6", "#9DD6DF", "#A084CF", "#FEF1E6", "#F9D5A7", "#FFB085", "#90AACB", "#AB46D2", "#FF6FB5", "#55D8C1", "#FCF69C", "#F6E3C5", "#A0D995", "#6CC4A1", "#4CACBC", "#97DBAE", "#C3E5AE", "#F1E1A6", "#F4BBBB", "#F9EBC8", "#FEFBE7", "#DAE5D0", "#A0BCC2", "#FF87CA", "#FFC4E1", "#EAEAEA", "#EED7CE"
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

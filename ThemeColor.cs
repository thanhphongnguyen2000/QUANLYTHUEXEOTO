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
            "#A8E6CF", "#DCEDC1", "#FFD3B6", "#FFAAA5", "#CCF6C8", "#FAFCC2", "#F6D6AD", "#F9C0C0", "#75CFB8", "#BBDFC8", "#F0E5D8", "#FFC478", "#28DF99", "#99F3BD", "#D2F6C5", "#F6F7D4", "#FFB6B9", "#FAE3D9", "#BBDED6", "#8AC6D1", "#98DDCA", "#D5ECC2", "#FFD3B4", "#FFAAA7", "#40DFEF", "#B9F8D3", "#FFFBE7", "#E78EA9", "#F5F0BB", "#C4DFAA", "#90C8AC", "#73A9AD", "#FFE6E6", "#F2D1D1", "#DAEAF1", "#C6DCE4", "#FCF8E8", "#94B49F", "#ECB390", "#DF7861"
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

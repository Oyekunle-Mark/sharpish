using System;

namespace color_class
{
    class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }

        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public byte GetBlue()
        {
            return blue;
        }

        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }

        public byte GetGreen()
        {
            return green;
        }

        public void SetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }

        public int FindGrayscale()
        {
            return (red + green + blue) / 3;
        }
    }
}

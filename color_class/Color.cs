using System;

namespace color_class
{
    class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

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

        public byte GetRed()
        {
            return red;
        }

        public void SetRed(byte red)
        {
            this.red = red;
        }

        public byte GetBlue()
        {
            return blue;
        }

        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }
    }
}

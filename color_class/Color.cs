using System;

namespace color_class
{
    class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; } = 255;

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public int FindGrayscale()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}

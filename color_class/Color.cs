using System;

namespace color_class
{
    class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; } = 255;

        public int FindGrayscale()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}

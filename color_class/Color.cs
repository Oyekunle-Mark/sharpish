using System;

namespace color_class
{
    class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; } = 255;

        /// <summary>
        /// Finds the grayscale of a color
        /// </summary>
        /// <returns>The grayscale computed</returns>
        public int FindGrayscale()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}

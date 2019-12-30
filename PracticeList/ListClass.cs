using System;

namespace ListClass
{
    class PracticeList<T>
    {
        private T[] items;

        public PracticeList()
        {
            items = new T[0];
        }
    }
}

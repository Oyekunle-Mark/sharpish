using System;

namespace ListClass
{
    class PracticeList<T>
    {
        private T[] items;

        public PracticeList()
        {
            /// <summary>
            ///     Creates a poor man's List class
            /// </summary>
            items = new T[0];
        }

        public T GetItem(int index)
        {
            return items[index];
        }

        public void Add(T item)
        {
            T[] newItems = new T[items.Length + 1];

            for (int i = 0; i < items.Length; i++)
                newItems[i] = items[i];

            newItems[items.Length] = item;
            items = newItems;
        }
    }
}

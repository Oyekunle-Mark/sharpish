using System;

namespace ListClass
{
    /// <summary>
    ///     Creates a test List class instance
    /// </summary>
    /// <typeparam name="T">Generic type of List item</typeparam>
    class PracticeList<T>
    {
        private T[] items;

        public PracticeList()
        {
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

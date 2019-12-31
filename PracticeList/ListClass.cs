using System;

namespace ListClass
{
    class PracticeList<T>
    {
        private T[] items;

        /// <summary>
        /// Creates a test List class instance
        /// </summary>
        /// <typeparam name="T">Generic type of List item</typeparam>
        public PracticeList()
        {
            items = new T[0];
        }

        /// <summary>
        /// Get's an item from the list
        /// </summary>
        /// <param name="index">The position of the item in the list</param>
        /// <returns>The item at the position on index in list</returns>
        public T GetItem(int index)
        {
            return items[index];
        }

        /// <summary>
        /// Adds an item to the list
        /// </summary>
        /// <param name="item">The item to be added</param>
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

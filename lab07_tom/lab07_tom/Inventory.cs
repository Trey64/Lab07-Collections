using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab07_tom
{
    class Inventory<T> : IEnumerable<T>
    {
        T[] items = new T[10];
        int count = 0;

        public void Add(T item)
        {
            items[count] = item;
            count++;
            if(count == items.Length)
            {
                int index = count * 2;
                T[] extension = new T[index];
                Array.Copy(items, extension, index);
                items = extension;
            }
        }

        //public void Remove(T item)
        //{
        //    int removeAt = Array.IndexOf(items, item);
        //    bool remove = false;
        //    T[] newArray = new T[items.Length];

        //    for(int i = 0; i < count; i++)
        //    {
        //        if(remove)
        //        {
        //            newArray[i - 1] = items[i];
        //        }
                
        //        if(i != removeAt && !remove)
        //        {
        //            newArray[i] = items[i];
        //        }
        //        else
        //        {
        //            remove = true;
        //        }

        //    }
        //    items = newArray;

        //    //items[count] = item;
        //    count--;
        //}

        
        public void Remove(T item)
        {
            T[] temp = new T[count - 1];
            int tempCount = 0;
            foreach(T i in items)
            {
                if(i != null)
                {
                    if(!i.Equals(item))
                    {
                        temp[tempCount] = i;
                        tempCount++;
                    }
                }
            }
            items = temp;
            count--;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

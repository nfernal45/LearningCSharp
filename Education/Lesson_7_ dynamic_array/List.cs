using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7__dynamic_array
{
    public class List<T>
        
    {
        public T[] array; 
        public List() { array = new T[1]; }

        public List(int size) { array = new T[size]; }


        public void Add<T>(T t)
        {
            var p = (List<T>) t;
            int lenght = array.Length;
            Array.Resize(ref array, lenght +1);
            array[lenght + 1] = t;

        }
        
       public void RemoveOnIndex(int index)
        {
            T[] newarray = new T[array.Length - 1];

            for (int i = 0; i < index; i++)
                newarray[i] = array[i];
            for (int i = index; i < array.Length; i++)
                newarray[i - 1] = array[i];

            array = newarray;

        }

        public void RemoveAt<T>(T t)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int index = Array.IndexOf(array, t);
                RemoveOnIndex(index);
            }
        }

        public int Count()
        {

            return array.Length;

        }
    }
}

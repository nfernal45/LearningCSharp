using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7__dynamic_array
{
    public class List<T> where T : IComparable<T>


    {
        public T[] array; 
        public List() { array = new T[1]; }

        public List(int size) { array = new T[size]; }


        public void Add(T t)
        {
            
            int lenght = array.Length;
            Array.Resize(ref array, lenght + 1);
            array[lenght] = t;

        }
        
       public void RemoveAt(int index)
        {
            T[] newarray = new T[array.Length - 1];

            for (int i = 0; i < index; i++)
                newarray[i] = array[i];
            for (int i = index; i < array.Length; i++)
                newarray[i - 1] = array[i];

            array = newarray;

        }

        public void Remove(T t)
        {
            int lenght = array.Length - 1;
            for (int i = 0; i < lenght; i++)
            {  
                int index = Array.IndexOf(array, t);
                    //if (search.CompareTo(t) == 0)
                        RemoveAt(index);
            }
        }

        public int Count()
        {

            return array.Length;

        }

        public T this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, T2>
    {
        T[] keys;
        T2[] values;
        //constructor
        public MyDictionary()
        {
            keys = new T[0];
            values = new T2[0];
        }
        
        public void Add(T key, T2 value)
        {
            T[] tempKeys = keys;
            T2[] tempValues = values;

            keys = new T[keys.Length + 1];
            values = new T2[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;
            
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            values[values.Length - 1] = value;
        }

        public void Print()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("İsim: " + keys[i] + " - Doğum günü: " + values[i]);
            }
        }
        

    }
}

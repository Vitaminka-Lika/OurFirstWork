using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Array
    {
        public object[] array;
        int count;

        public Array(int n)
        {
            array = new object[n];
            count = n;
        }

        public void Add(object obj)
        {
            object[] temp = new object[count + 1];
            for (int i = 0; i < count; ++i)
            {
                temp[i] = array[i];
            }
            
            temp[count] = obj;
            ++count;

            array = new object[count];

            for (int i = 0; i < count; ++i)
            {
                array[i] = temp[i];
            }
        }

        public void Remove(object obj)
        {
            for (int i = 0; i < count; ++i)
            {
                if (array[i] == obj)
                {
                    object[] temp = new object[count - 1];
                    for (int j = 0; j < count; ++j)
                    {
                        if (j < i)
                            temp[j] = array[j];
                        else
                            temp[j] = array[j + 1];
                    }
                    --count;

                    array = new object[count];
                    for (int j = 0; j < count; ++j)
                    {
                        array[j] = temp[j];
                    }
                }
            }
        }

        public object Get(int index)
        {
            return array[index];
        }
    }
}

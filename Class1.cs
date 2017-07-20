using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Array
    {
        private ProductClass[] array;
        int count;

        public Array(int n)
        {
            array = new ProductClass[count];
            count = n;
        }

        public void Add(string obj)
        {
            ProductClass[] temp = new ProductClass[count + 1];
            for (int i = 0; i < count; ++i)
            {
                temp[i] = array[i];
            }

            temp[count] = obj;
            ++count;

            array = new ProductClass[count];

            for (int i = 0; i < count; ++i)
            {
                array[i] = temp[i];
            }
        }

        public void Remove(string obj)
        {
            for (int i = 0; i < count; ++i)
            {
                if (array[i] == obj)
                {
                    ProductClass[] temp = new ProductClass[count - 1];
                    for (int j = 0; j < count; ++j)
                    {
                        if (j < i)
                            temp[j] = array[j];
                        else
                            temp[j] = array[j + 1];
                    }
                    --count;

                    array = new ProductClass[count];
                    for (int j = 0; j < count; ++j)
                    {
                        array[j] = temp[j];
                    }
                }
            }
        }

        public object Get(int index)
        {
            return index + ' ' + array[index];
        }

    }
}
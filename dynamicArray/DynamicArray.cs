using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicznaTablica
{
    public delegate void MyDelegate(int tabSize);

    class DynamicArray
    {
        private int[] array;
        private int index = 0;
        
        private MyDelegate myDelegate = null;

        public DynamicArray()
        {
            array = new int[1];
            myDelegate += tabSize;
        }
        public DynamicArray(int size)
        {
            array = new int[size];
            myDelegate += tabSize;
        }

        public void tabSize(int sizeOfArray)
        {
            Console.WriteLine("Rozmiar tablicy: " + sizeOfArray);
        }

        public void printAllElements()
        {
            for (int i = 0; i < index; i++)
            {
                getElement(i);
            }

            Console.WriteLine("TAB LENGTH: " + array.Length);
        }

        public void addElement(int x)
        {
            if (index >= array.Length)
            {
                makeBigger(2 * array.Length);
            }
            array[index++] = x;

            myDelegate(array.Length);
        }

        public void setElement(int indx, int value)
        {
            if (indx >= array.Length)
            {
                makeBigger(indx + 1);
                Console.WriteLine("NEW TAB LENGTH: " + array.Length);
                index = indx;
            }
            array[indx] = value;

            Console.WriteLine("New value from index " + indx + " is: " + array[indx]);

        }


        public void makeBigger(int ile)
        {
            int[] temp = new int[array.Length];
            Array.Copy(array, temp, index);
            array = new int[ile];
            Array.Copy(temp, array, index);

            //dac delegata na event
        }

        public int getElement(int indx)
        {
            if (indx <= index)
            {
                Console.WriteLine("Element form index " + indx + " is: " + array[indx]);
                return array[indx];
            }
            else
            {
                throw new IndexOutOfRangeException("Index poza skala");
            }

        }
    }
}

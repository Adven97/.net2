using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicznaTablica
{
    class Program
    {
        private static int[] array;
        private static int index = 0;
        static void Main(string[] args)
        {
            init(5);

            add(1);
            add(2);
            add(21);
            add(221);
            add(21232);
            add(55);
            add(567);
            //get(12);
            
            for(int i=0; i < array.Length; i++)
            {
                Console.WriteLine("tab is: " + array[i]);
            }
            
            Console.WriteLine("tab length is: " + array.Length);
            

            Console.ReadLine();
        }

        static void init(int size)
        {
            array = new int[size];
            
        }

        static int get(int indx)
        {
            try
            {
                return array[indx];
            }
            catch (System.IndexOutOfRangeException ex)
            {
                Console.WriteLine("wywalilo po za skale, erroer: " + ex);
                throw new System.ArgumentException("Index wyjebal poza skale", "index", ex);

            }
           
        }
    
        

        static void add(int x)
        {
            if (index >= array.Length)
            {
                makeBigger();
            }

            array[index++] = x;
           
        }

        static void makeBigger()
        {
            int[] temp = new int[array.Length];
            Array.Copy(array, temp, index);
            array = new int[1+ array.Length];
            Array.Copy(temp, array, index);
            
        }
    }
}

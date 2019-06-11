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
            DynamicArray array = new DynamicArray(5);

            array.addElement(1);
            array.addElement(2);
            array.addElement(21);
            array.addElement(221);
            array.addElement(21232);
            array.addElement(55);
            array.addElement(567);


            array.printAllElements();
            Console.WriteLine();
            array.setElement(25, 92);
            Console.WriteLine();

            try
            {
                array.getElement(66);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception occured: " + e.Message);
            }

            Console.ReadLine();
        }

    }
}

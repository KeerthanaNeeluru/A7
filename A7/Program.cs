using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            al.Add("Apple");
            al.Add("Banana");
            al.Add("Cherry");
            al.Add("Date");
            al.Add("ElderBerry");
            Console.WriteLine("Total number of elements in array list  :  "+al.Count);

            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            var res=al.Contains("Date");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Check if array list contain the elemnt Date in it "+res);
            Console.WriteLine("-----------------------------------");
            al.Insert(1, "Fig");
            Console.WriteLine("After inserting Fig into array list ");
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------------");
            al.Remove("Banana");
            Console.WriteLine("Array list after removing Banana from list ");
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------------");


            Console.ReadKey();
        }
    }
}

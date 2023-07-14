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
            ArrayList al = new ArrayList();
            al.Add("Apple");
            al.Add("Banana");
            al.Add("Cherry");
            al.Add("Date");
            al.Add("ElderBerry");
            Console.WriteLine("Total number of elements in array list  :  " + al.Count);

            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------------");

            int ch,pos;
            string ele,quit;
            do
            {
                Console.WriteLine("Select the Operation :\n1.Search\n2.Insert\n3.Remove");
                ch = int.Parse(Console.ReadLine());
            
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Enter the valuse you want to check in array list :");
                        ele = Console.ReadLine();
                        if (al.Contains(ele))
                        {

                            Console.WriteLine("Value is present in Array list ");
                        }
                        else { Console.WriteLine("Value is not present in array list"); }
                        Console.WriteLine("-----------------------------------");
                        break;

                    case 2:
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Enter the value you want to insert into the array list ");
                        ele = Console.ReadLine();
                        Console.WriteLine($"Enter the position where you want to insert {ele}");
                        pos = int.Parse(Console.ReadLine());
                        al.Insert(pos - 1, ele);
                        Console.WriteLine($"After inserting {ele} into array list  at {pos} ");
                        foreach (var i in al)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Enter the value you want to delete : ");
                        ele = Console.ReadLine();
                        al.Remove(ele);
                        Console.WriteLine("Array list after removing Banana from list ");
                        foreach (var i in al)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("-----------------------------------");
                        break;

                    default:
                        Console.WriteLine("Operation doesnot exist"); break;
                }
                Console.WriteLine("If you want to continue type yes ");
                quit=Console.ReadLine().ToLower();
            } while (quit == "yes");
            


            
        
            

          
        
           
        

            Console.ReadKey();
        }
    }
}

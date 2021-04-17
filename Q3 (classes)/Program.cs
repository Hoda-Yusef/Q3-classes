using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil3
{
    public class Class1
    {
        static void Main(string[] args)
        {
            newCounter first = new newCounter(5, 10); 
            MyVar var1 = new MyVar(0, 5);
            int num,option;
            string str= string.Empty;


            do
            {
                Console.WriteLine("NewCounter -\n");
                Console.WriteLine("1) Set a new counter");
                Console.WriteLine("2) Get counter");
                Console.WriteLine("3) increment 1 to counter");
                Console.WriteLine("4) decrement 1 from counter");
                Console.WriteLine("-1) Move to myVar");

                str = Console.ReadLine();
                option = Convert.ToInt32(str);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter a new counter");
                        str = Console.ReadLine();
                        num = Convert.ToInt32(str);
                        if (first.set_counter(num))
                            Console.WriteLine("Counter updated");
                        else
                            Console.WriteLine("Number Not in range");
                        break;

                    case 2:
                        Console.WriteLine(first.get_counter());
                        break;

                    case 3:
                        if (first.inc_counter())
                            Console.WriteLine("Added");
                        else
                            Console.WriteLine("Can not increment counter");
                        break;

                    case 4:
                        if (first.dec_counter())
                            Console.WriteLine("Decremented");
                        else
                            Console.WriteLine("Can not decrement counter");
                        break;

                    case -1:
                        Console.WriteLine("Moved");
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }

            } while (option != -1);


            do
            { 
            Console.WriteLine("myVar -\n");
            Console.WriteLine("1) Set a new counter for number 1");
            Console.WriteLine("2) Set a new counter for number 2");
            Console.WriteLine("3) Get counter 1");
            Console.WriteLine("4) Get counter 2");
            Console.WriteLine("5) Sum of two counters");
            Console.WriteLine("6) Max of two counters");
            Console.WriteLine("-1) Exit");

            str = Console.ReadLine();
            option = Convert.ToInt32(str);

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter a new counter 1");
                    str = Console.ReadLine();
                    num = Convert.ToInt32(str);
                    if (var1.set_counter1(num))
                        Console.WriteLine("Counter updated");
                    else
                        Console.WriteLine("Number Not in range");
                    break;

                case 2:
                        Console.WriteLine("Enter a new counter 1");
                        str = Console.ReadLine();
                        num = Convert.ToInt32(str);
                        if (var1.set_counter2(num))
                            Console.WriteLine("Counter updated");
                        else
                            Console.WriteLine("Number Not in range");
                        break;

                    case 3:
                        Console.WriteLine(var1.get_counter1());
                        break;

                    case 4:
                        Console.WriteLine(var1.get_counter2());
                        break;
                    

                case 5:
                        Console.WriteLine(var1.sum_counters());
                    break;

                    case 6:
                        Console.WriteLine(var1.maxOf());
                        break;

                    case -1:
                        Console.WriteLine("Done !");
                        break;

                default:
                    Console.WriteLine("Invalid option");
                    break;

            }

        } while (option != -1);

            
            

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int f = num / 100;//first digit
            int s = (num / 10) % 10;//second digit
            int t = num % 10;//third digit
        
            if (f >= s && f >= t && s>=t)
            {
                    Console.WriteLine("{0}{1}{2} ", f,s,t);
            }
            else if (f >= s && s <= t)
            {
                    Console.WriteLine("{0}{1}{2} ", f, t, s);
            }
            else if (t >= f && s >= f)
            {
     
                    Console.WriteLine("{0}{1}{2} ", t, s, f);
            }
            else if (s >= f && t >= f)
            {

                Console.WriteLine("{0}{1}{2} ", s, t, f);
            }
            else if (s >= f && f >= t)
            {

                Console.WriteLine("{0}{1}{2} ", s, f, t);
            }
            Console.ReadLine();
        }
    }
}

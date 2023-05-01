using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money does Peter have: ");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cost of notebook:");
            int notebook = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cost of pen:");
            int pen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of notebook");
            int notebookBuy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cost of pen:");
            int penBuy = Convert.ToInt32(Console.ReadLine());
            int sum = notebook * notebookBuy + pen * penBuy;
            Console.WriteLine($"Sum= {sum}");
            if (money < sum)
            {
                Console.WriteLine("Not enough money!");
            }
            else
            {
                int r;
                r = money - sum;
                Console.WriteLine($"The rest of money:{r}");
            }
            Console.ReadLine();

        }
    }
}

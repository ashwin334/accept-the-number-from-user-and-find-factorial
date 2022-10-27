using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_the_number_from_user_and_find_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fact = 1;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());  
            for(int i=1; i<=num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}

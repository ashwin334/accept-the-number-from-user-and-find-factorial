﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_the_number_from_user_and_find_factorial
{
    internal class armstrong_number
    {
        static void Main(string[] args)
        {
           int num, sum = 0, temp, rem;
           Console.WriteLine("Enter the number");
           num=Convert.ToInt32(Console.ReadLine());
           temp = num;
           while(num >0)
            {
             rem =num% 10;
            sum=sum +rem+rem* rem;
            num=num/10;

            }
            if (temp == sum)
           {
           Console.WriteLine("its a armstrong number");
           }else
            Console.WriteLine("not a armstrong number");
           Console.ReadLine();

           }
    }
}

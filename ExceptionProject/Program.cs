﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Exception....");

            Console.WriteLine("....Exception....");
            Console.WriteLine("\n1:Age Determination \n22:default");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int age = 30;
                    string category = PersonCategory.CategorizeAge(age);
                    Console.WriteLine($"The person's age is {age} and belongs to {category} category");
                    break;
                default:
                    Console.WriteLine("choose the above option");
                    break;
            }
            Console.ReadLine();
        }
    }
}

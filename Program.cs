﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Return_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(5));
            Console.ReadLine(); 
        }

        static int cube(int num)
        {
            int result = num * num * num; 
            return result;
        }

    }
}

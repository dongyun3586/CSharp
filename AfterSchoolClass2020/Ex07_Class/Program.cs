﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube cube1 = new Cube(1, 2, 3);
            Console.WriteLine($"cube1의 부피 : {cube1.GetVolume()}");

            Cube cube2 = new Cube(10, 20, 30);
            Console.WriteLine($"cube1의 부피 : {cube2.GetVolume()}");
        }
    }
}

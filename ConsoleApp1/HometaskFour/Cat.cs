﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HometaskFour
{
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("I can meow");
        }

        public Cat(double weight, int age): base(weight, age) { }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial.Core.ExampleFive
{
    class Fish : Animal
    {
        public Fish()
        {
            WhatAnimalSays = "...";
        }

        public override string Walk()
        {
            //return base.Walk();
            return "I'm a fish, I don't walk (no legs)";
        }
    }
}

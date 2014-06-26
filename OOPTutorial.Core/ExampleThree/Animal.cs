using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial.Core.ExampleThree
{
    class Animal
    {
        protected string WhatAnimalSays { get; set; }

        public string Speak()
        {
            return WhatAnimalSays;
        }
    }
}

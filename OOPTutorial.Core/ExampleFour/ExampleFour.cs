﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial.Core.ExampleFour
{
    public class ExampleFour
    {
        public string Go()
        {
            Dog dog = new Dog();
            Bird bird = new Bird();
            Fish fish = new Fish();

            var dogWalking = dog.Walk();
            var birdWalking = bird.Walk();
            var fishWalking = fish.Walk();

            return dogWalking + "\r\n" + birdWalking + "\r\n" + fishWalking + "\r\n";
        }
    }
}

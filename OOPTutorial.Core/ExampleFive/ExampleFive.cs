using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial.Core.ExampleFive
{
    public class ExampleFive
    {
        public string Go()
        {
            Animal dog = new Dog();
            Animal bird = new Bird();
            Animal fish = new Fish();

            var dogWalking = dog.Walk();
            var birdWalking = bird.Walk();
            var fishWalking = fish.Walk();

            return dogWalking + "\r\n" + birdWalking + "\r\n" + fishWalking + "\r\n";
        }
    }
}

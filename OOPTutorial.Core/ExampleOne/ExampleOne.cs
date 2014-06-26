using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial.Core.ExampleOne
{
    public class ExampleOne
    {
        public string Go()
        {
            var dog = new Dog();
            var bird = new Bird();
            var fish = new Fish();

            var dogSays = dog.Speak();
            var birdSays = bird.Speak();
            var fishSays = fish.Speak();

            return dogSays + "\r\n" + birdSays + "\r\n" + fishSays + "\r\n";
        }
    }
}

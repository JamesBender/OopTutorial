using System;
using System.Linq;
using OOPTutorial.Core.ExampleFive;
using OOPTutorial.Core.ExampleFour;
using OOPTutorial.Core.ExampleOne;
using OOPTutorial.Core.ExampleThree;
using OOPTutorial.Core.ExampleTwo;

namespace OOPTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleOne = new ExampleOne();
            var exampleOneResult = exampleOne.Go();

            var exampleTwo = new ExampleTwo();
            var exampleTwoResult = exampleTwo.Go();

            var exampleThree = new ExampleThree();
            var exampleThreeResult = exampleThree.Go();

            var exampleFour = new ExampleFour();
            var exampleFourResult = exampleFour.Go();

            var exampleFive = new ExampleFive();
            var exampleFiveResult = exampleFive.Go();

            Console.WriteLine(exampleOneResult);
            //Console.WriteLine(exampleTwoResult);
            //Console.WriteLine(exampleThreeResult);
            //Console.WriteLine(exampleFourResult);
            //Console.WriteLine(exampleFiveResult);

            Console.ReadKey();
        }
    }
}

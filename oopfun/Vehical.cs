using System;

namespace oopfun
{
    public class dog
    {
        string Breed;
        string Color;
        string Coat;
        public dog(string breed, string color, string coat)
        {
            Breed = breed;
            Color = color;
            Coat = coat;
        }
        public void displayDog()
        {
            Console.WriteLine("Let me get this strait.");
            Console.WriteLine($"Your dog  is a {Breed} with a coat of {Coat} and color {Color}");
            
        }
    }
}
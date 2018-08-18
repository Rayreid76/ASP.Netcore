using System;

namespace oopfun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INput: ");
            int inputValues = int.Parse(Console.ReadLine());
            dog dog1 = new dog("Pit", "Black", "Short hair");
            dog1.displayDog();
        }
    }
}

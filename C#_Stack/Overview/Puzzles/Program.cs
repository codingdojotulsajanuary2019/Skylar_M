using System;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            Functions.RandomArray(10, 5, 25);
            Functions.TossCoin();
            Functions.TossMultipleCoins(10);
            Functions.Names();
            Console.WriteLine("----------------------------------");
        }
    }
}

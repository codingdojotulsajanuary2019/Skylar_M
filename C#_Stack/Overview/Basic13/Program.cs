using System;


namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] Array = {1,-2,3,-4,5,-6,7,8,9};
            Basic13.PrintNumbers(255);
            Basic13.returnOdds(255);
            Basic13.PrintSum(255);
            Basic13.LoopArray(Array);
            Basic13.MaxMinAvg(Array);
            Basic13.FindMax(Array);
            int [] result = Basic13.OddArray();
            Console.Write(result);
            Basic13.GreaterThanY(Array, 2);
            Basic13.SquareArrayValues(Array);
            Basic13.EliminateNegatives(Array);
            Basic13.ShiftValues(Array);
            Basic13.NumToString(Array);
        }
    }
}

using System;

namespace Fudamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 255; i++){
                Console.WriteLine(i);
            }

            // *********************** //

            for(int i = 0; i <= 100; i++){
                if(i % 3 == 0 && i % 5 == 0){
                }
                else if(i % 3 == 0){
                    Console.WriteLine(i);
                }
                else if(i % 5 == 0){
                    Console.WriteLine(i);
                }
            }
            // *********************** //

            for(int j = 0; j <= 100; j++){
                if(j % 3 == 0 && j % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                else if(j % 3 == 0){
                    Console.WriteLine("Fizz");
                }
                else if(j % 5 == 0){
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}

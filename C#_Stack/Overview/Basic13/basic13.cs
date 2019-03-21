using System;
using System.Collections.Generic;

namespace practice
{

    class Basic13
    {
        public static void PrintNumbers(int num)
        {
            for(int i = 0; i <= num; i++ )
            {
                Console.WriteLine(i);
            }
        }
        public static void returnOdds(int num)
        {
            for(int i = 0; i <= num; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum(int num)
        {
            int sum = 0;

            for(int i = 0; i <=num; i++)
            {
                sum += i;
                Console.WriteLine($"New Number = {i} Sum:{sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void FindMax(int [] numbers)
        {
            int max = numbers[0];
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
        }

        public static void MaxMinAvg(int [] argArr)
        {
            int[] newArr = argArr;
            int max = newArr[0];
            int min = newArr[0];
            int sum = 0;
            int avg = 0;
            for(int x = 0; x < newArr.Length; x++)
            {
                sum = sum + newArr[x];

                if(newArr[x] > max)
                {
                    max = newArr[x];
                }
                if(newArr[x] < min)
                {
                    min = newArr[x];
                }

            }
            avg = sum / newArr.Length;
            Console.WriteLine($"Max is {max}");
            Console.WriteLine($"Min is {min}");
            Console.WriteLine($"Average is {avg}");
        }

        public static int[] OddArray()
        {
            int count = 0;
            for(int i = 0; i <= 255; i++)
            {
                if(i % 2 !=0)
                {
                    count +=1;
                }
            }
            int [] numArray = new int[count];
            int index = 0;
            for(int x = 0; x<=255; x++){
                if(x % 2 != 0)
                {
                    numArray[index] = x;
                    index += 1;
                }
            } 
            // for(int z=0; z<numArray.Length; z++)
            // {
            //     // Console.Write(numArray[z] +  " ");
            // }
                return numArray;

        }

        public static void GreaterThanY(int[] numbers, int y)
        {
            int count = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > y)
                {
                    count ++;
                }
            }
            Console.WriteLine(count);
        }

        public static void SquareArrayValues(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
                Console.Write(numbers[i] + " ");
            }
            
        }

        public static void EliminateNegatives(int[] numbers)
        {
            for(int i =0; i< numbers.Length; i++)
            {
                if(numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
                Console.Write(numbers[i] + " ");
            }
        }
        
        public static void ShiftValues(int[] numbers)
        {
            for(int i = 0; i < numbers.Length-1; i++)
            {
                numbers[i] = numbers[i+1];
                Console.Write(numbers[i] + " ");
            }
            numbers[numbers.Length-1] = 0;
            Console.Write(numbers[numbers.Length-1]+ " ");
        }

        public static object[] NumToString(int[] numbers)
        {
            object [] x = new object [numbers.Length];
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < 0)
                {
                    string dojo = "Dojo";
                    x[i]= dojo;
                }
                else
                {
                    x[i] = numbers[i];
                }
            Console.Write(x[i] + " , ");
            }
            return x;
        }


    }
}
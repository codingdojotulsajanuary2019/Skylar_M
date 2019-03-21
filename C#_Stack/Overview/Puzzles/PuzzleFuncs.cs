using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Functions
    {
        public static int[] RandomArray(int size, int low, int high){
            int[] RandArr = new int[size];
            Random rand = new Random();
            int Min = high;
            int Max = low;
            int Sum = 0;
            for(int i = 0; i < RandArr.Length; i++){
                RandArr[i] = rand.Next(low, high+1);
                Console.WriteLine(RandArr[i]);
                if(RandArr[i] > Max){
                    Max = RandArr[i];
                }
                if(RandArr[i] < Min){
                    Min = RandArr[i];
                }
                Sum += RandArr[i];
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Max = {Max}");
            Console.WriteLine($"Min = {Min}");
            Console.WriteLine($"Sum = {Sum}");
            Console.WriteLine("----------------------------------");
            return RandArr;
        }
        public static string TossCoin(){
            Console.WriteLine("Tossing A Coin!");
            string CoinState = null;
            Random rand = new Random();
            int BinRes = rand.Next(0,2);
            if(BinRes == 0){
                CoinState = "Heads!";
            }
            if(BinRes == 1){
                CoinState = "Tails!";
            }
            Console.WriteLine(CoinState);
            Console.WriteLine("----------------------------------");
            return CoinState;

        }
        public static double TossMultipleCoins(int flips){
            string Res;
            double TotalFlips = flips;
            double Heads = 0;
            double Ratio = new double();
            while(flips > 0){
                Res = Functions.TossCoin();
                if(Res == "Heads!"){
                    Heads+=1;
                }
                flips -= 1;
            }
            Ratio = Heads / TotalFlips;
            Console.WriteLine(Ratio);
            Console.WriteLine("----------------------------------");
            return Ratio;
        }
        public static List<string> Names(){
            List<string> People = new List<string>();
            People.Add("Todd");
            People.Add("Tiffany");
            People.Add("Charlie");
            People.Add("Geneva");
            People.Add("Sydney");
            for(int i = 0; i < People.Count; i++){
                Console.WriteLine(People[i]);
            }
            int n = People.Count;
            Random Rand = new Random();
            while(n > 1){
                int k = (Rand.Next(0, n) % n);
                n--;
                string Value = People[k];
                People[k] = People[n];
                People[n] = Value;
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("**Shuffle**");
            Console.WriteLine("----------------------------------");
            for(int i = 0; i < People.Count; i++){
                Console.WriteLine(People[i]);
            }
            Console.WriteLine("----------------------------------");
            for(int i = 0; i < People.Count; i++){
                if(People[i].Length > 5){
                    Console.WriteLine(People[i]);
                    People.RemoveAt(i);
                    i--;
                }
            }
            return People;
        }

    }
}
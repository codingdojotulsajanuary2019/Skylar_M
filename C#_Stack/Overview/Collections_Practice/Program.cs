using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string returnArr = "[";
            int [] One_Through_Nine = new int[9];
            for(int i = 0; i < One_Through_Nine.Length; i++){
                One_Through_Nine[i]=i+1;
                returnArr += One_Through_Nine[i].ToString();
            }
            returnArr += "]";
            Console.WriteLine(returnArr);





            string [] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            Console.WriteLine(names.Length);
            


            
            Console.Write("[");
            bool [] T_F = new bool [10];
            for(int i = 0; i < T_F.Length; i+=2){
                T_F[i] = true;
                T_F[i+1] = false;
                Console.Write(T_F[i]);
                Console.Write(", ");
                Console.Write(T_F[i+1]);
                Console.Write(", ");
            }
            Console.WriteLine("]");



            List<string> Ice_Cream = new List<string>();
            Ice_Cream.Add("Vanilla");
            Ice_Cream.Add("Chocolate");
            Ice_Cream.Add("Strawberry");
            Ice_Cream.Add("Cookie Dough");
            Ice_Cream.Add("Chocolate Chip");
            Console.WriteLine(Ice_Cream.Count);
            Console.WriteLine(Ice_Cream[2]);
            Ice_Cream.RemoveAt(2);
            Console.WriteLine(Ice_Cream.Count);

            // ******************************************** //


            Dictionary<string,string> info = new Dictionary<string,string>();
            foreach(string name in names){
                info.Add(name, null);
            }
            
            
            Random Rand = new Random();
            foreach(string name in names){
                info[name] = Ice_Cream[Rand.Next(0,Ice_Cream.Count)];
            }
            
            foreach(KeyValuePair<string,string> result in info){
                Console.WriteLine(result);
            }

        }
    }
}

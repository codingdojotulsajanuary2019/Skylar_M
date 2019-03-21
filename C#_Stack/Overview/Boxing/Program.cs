using System;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> Boxing = new List<object>();
            object ListItem1 = 7;
            object ListItem2 = 28;
            object ListItem3 = -1;
            object ListItem4 = true;
            object ListItem5 = "chair";
            Boxing.Add(ListItem1);
            Boxing.Add(ListItem2);
            Boxing.Add(ListItem3);
            Boxing.Add(ListItem4);
            Boxing.Add(ListItem5);
            
            for(int i=0; i<Boxing.Count; i++){
            Console.WriteLine(Boxing[i]);
            }

            int Sum = 0;
            for(int i=0; i<Boxing.Count; i++){
                if(Boxing[i] is int){
                    int Number = (int)Boxing[i];
                    Sum += Number;
                }
            }
            Console.WriteLine(Sum);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    public class Buffet{
        public List<IConsumable> Menu;
        
        //constructor
        public Buffet(){
            Menu = new List<IConsumable>(){
                new Food("Tacos", 800, true, false),
                new Food("Sub", 1000, false, false),
                new Food("Hot Wings", 700, true, false),
                new Food("Cake", 450, false, true),
                new Food("Cookie", 250, false, true),
                new Food("Pizza", 600, false, false),
                new Food("Pancakes", 500, false, true),
                new Drink("Soda", 300, false, true),
                new Drink("Milkshake", 500, false, true),
            };
        }
        
        public IConsumable Serve(){
            Random rand = new Random();
            int Idx = rand.Next(0, Menu.Count);
            return Menu[Idx];
        }
    }
}
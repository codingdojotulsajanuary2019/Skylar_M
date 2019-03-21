using System;
using System.Collections.Generic;

namespace W_N_S
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name){
            Name = name;
            Dexterity = 175;

        }
        public override int Attack(Human target){
            int dmg = Dexterity * 5;
            target.Health -= dmg;
            Random Rand = new Random();
            if(Rand.Next(1,6) == 5){
                target.Health -= 10;
                Console.WriteLine("Critical Hit!");
            }
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public void Steal(Human target){
            target.Health -= 5;
            this.Health += 5;
            Console.WriteLine($"{Name} stole 5 Health from {target.Name}!");
        }
    }
}
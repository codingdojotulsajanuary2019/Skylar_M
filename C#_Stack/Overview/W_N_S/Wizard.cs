using System;
using System.Collections.Generic;

namespace W_N_S
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name){
            Name = name;
            Health = 50;
            Intelligence = 25;

        }

        public override int Attack(Human target){
            int dmg = Intelligence * 5;
            target.Health -= dmg;
            this.Health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public int Heal(Human target){
            int heal = Intelligence * 10;
            target.Health += heal;
            Console.WriteLine($"{Name} Healed {target.Name} by {heal} points!");
            return target.Health;
        }
    }
}
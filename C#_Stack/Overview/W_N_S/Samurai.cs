using System;
using System.Collections.Generic;

namespace W_N_S
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name){
            Name = name;
            Health = 200;

        }
        public override int Attack(Human target){
            base.Attack(target);
            if(target.Health < 50){
                target.Health = 0;
            }
            return target.Health;
        }
        public int Meditate(){
            this.Health = 200;
            Console.WriteLine($"{Name} meditated.");
            Console.WriteLine($"{Name}'s health is restored.");
            return this.Health;
        }
    }
}
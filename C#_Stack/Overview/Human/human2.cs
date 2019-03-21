using System;

namespace Human
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int HealthProp
        {
            get { return health; }
        }
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        
        public Human(string val1, int val2, int val3, int val4, int val5)
        {
            Name = val1;
            Strength = val2;
            Intelligence = val3;
            Dexterity = val4;
            health = val5;
        }
        public int Attack(string target, string attacker)
        {      
            foreach (var human in Human)
                {
                    if (human.name == attacker)
                        {   
                            Human fighter = human;
                            public int damage = fighter.Strength * 5;
                        }
                }
            foreach (var loser in Human){
                if(loser.name == target)
                {
                    Human beaten = loser;
                    beaten.health = beaten.health - damage;
                }

            }
            return beaten.health;
        }
        
    }

}

using System;

namespace Human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health{
            get { return health; }
        }

        public void SetName(string val){
            Name = val;
        }
        public void SetStats(int val){
            Strength = val;
        }
    }
}

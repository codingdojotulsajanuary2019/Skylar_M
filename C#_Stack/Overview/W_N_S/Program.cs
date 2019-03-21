using System;

namespace W_N_S
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Skylar = new Wizard("Skylar");
            Wizard Cros = new Wizard("Cros");
            int UpdatedHealth = Skylar.Attack(Cros);
            Console.WriteLine(UpdatedHealth);
            // Target = Cros //

        }
    }
}

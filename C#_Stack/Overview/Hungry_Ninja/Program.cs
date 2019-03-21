using System;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet NewBuffet = new Buffet();
            SweetTooth Skylar = new SweetTooth();
            SpiceHound Cros = new SpiceHound();
            
            int SkyCount = 0;
            int CrosCount = 0;

            while(Skylar.IsFull == false){
                IConsumable item = NewBuffet.Serve(); 
                Console.WriteLine(item);
                SkyCount += 1;
                Skylar.Consume(item);
            }
            while(Cros.IsFull == false){
                IConsumable item = NewBuffet.Serve(); 
                Console.WriteLine(item);
                CrosCount += 1;
                Cros.Consume(item);
            }
            if(SkyCount > CrosCount){
                Console.WriteLine("Skylar consumed more items.");
            }
            else if(CrosCount > SkyCount){
                Console.WriteLine("Cros consumed more items.");
            }
            else{
                Console.WriteLine("Ninjas ate the same number of items.");
                
            }
        }
    }
}

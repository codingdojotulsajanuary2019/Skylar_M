using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    public class SweetTooth : Ninja
    {
        
        public override bool IsFull{
            get{
                if(calorieIntake < 1500){
                    return false;
                }
                else{
                    return true;
                }
            }
        }

        public override void Consume(IConsumable item){
            if(IsFull == false){
                calorieIntake += item.Calories;
                if(item.IsSweet == true){
                    calorieIntake += 10;
                }
                ConsumptionHistory.Add(item);
                item.GetInfo();
                Console.WriteLine($"Ninja Consumed {item.Name}.");
            }
            else{
                Console.WriteLine("Ninja is full!");
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    public interface IConsumable
    {
        string Name {get;set;}
        int Calories {get;set;}
        bool IsSpicy {get;set;}
        bool IsSweet {get;set;}
        string GetInfo();
    }
}
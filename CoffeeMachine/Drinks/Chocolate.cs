﻿namespace CoffeeMachine.Drinks
{
    public class Chocolate : IDrink
    {
        public virtual string ShortName => "H";
        public double Cost => 0.5;
    }
}

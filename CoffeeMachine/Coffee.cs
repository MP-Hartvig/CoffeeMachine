using CoffeeMachine.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Liquids
{
    public class Coffee
    {
        public int CoffeeAmount;
        public string CoffeeStrength;

        public Coffee(Water water, Bean bean)
        {
            CoffeeAmount = GetWaterAmount(water);
            CoffeeStrength = GetCoffeeStrength(bean);
        }

        private int GetWaterAmount(Water water)
        {
            return water.Mililiter;
        }

        private string GetCoffeeStrength(Bean bean) 
        {
            float percentage = bean.Gram / 50;
            return percentage.ToString("P");
        }
    }
}

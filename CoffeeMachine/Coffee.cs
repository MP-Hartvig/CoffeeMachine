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
        int CoffeeAmount;
        int CoffeeStrength;

        public Coffee(Water water, Bean bean)
        {
            CoffeeAmount = GetWaterAmount(water);
            CoffeeStrength = GetBeanAmount(bean);
        }

        public int GetWaterAmount(Water water)
        {
            return water.Mililiter;
        }

        public int GetBeanAmount(Bean bean) 
        {
            return (bean.Gram - 50) / (300 - 50);
        }
    }
}

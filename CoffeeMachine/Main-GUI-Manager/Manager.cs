using CoffeeMachine.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Main_GUI_Manager
{
    internal class Manager
    {
        public void InitializeMachine(int waterAmount, int beanAmount, int degrees)
        {
            Water water = new Water(waterAmount);
            Bean bean = new Bean(beanAmount);

            Machine machine = new Machine();
        }
    }
}

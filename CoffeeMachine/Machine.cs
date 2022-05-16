using CoffeeMachine.Ingredients;
using CoffeeMachine.Interfaces;
using CoffeeMachine.Liquids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Machine : IHeater, IContainer, ISwitch, IFilter, IGrinder
    {
        public bool FilterInserted { get; set; }
        public int Degrees { get; set; }
        public bool OnOff { get; set; }

        public Machine() { }

        public void FillContainer() { }

        public void AddFilter() { }

        public void TurnOn() { }

        public void GrindBeans() { }

        public Coffee BrewCoffee(Water water, Bean beans) 
        {
            Coffee coffee = new Coffee(water, beans);
            return coffee;
        }

        public void TurnOff() { }

        public void RemoveFilter() { }
    }
}

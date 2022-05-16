﻿using CoffeeMachine.Ingredients;
using CoffeeMachine.Liquids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Main_GUI_Manager
{
    internal class Manager
    {
        Machine machine = new Machine();
        Coffee coffee;

        public string[] BrewCoffee(int waterAmount, int beanAmount, int degrees)
        {
            Water water = new Water(waterAmount);
            Bean beans = new Bean(beanAmount);

            machine.AddFilter();
            machine.FilterInserted = true;
            machine.Degrees = degrees;
            machine.OnOff = true;
            machine.FillContainer();
            machine.GrindBeans();
            coffee = machine.BrewCoffee(water, beans);
            machine.OnOff = false;
            machine.RemoveFilter();

            string[] coffeeDetails = new string[2];
            coffeeDetails[0] = coffee.CoffeeAmount.ToString();
            coffeeDetails[1] = coffee.CoffeeStrength.ToString();

            return coffeeDetails;
        }
    }
}

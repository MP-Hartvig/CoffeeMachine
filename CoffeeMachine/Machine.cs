using CoffeeMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Machine : IHeater, IContainer, ISwitch, IFilter
    {
        public int MinDegrees { get; }
        public int MaxDegrees { get; }
        public int ActualDegrees { get; }

        public int MinAmount { get; }
        public int MaxAmount { get; }
        public int ActualAmount { get; }

        bool ISwitch.OnOff { get; }

        bool IFilter.FilterInserted { get; }

        public Machine() { }

        public void FillContainer() { }

        public void TurnOn() { }

        public void TurnOff() { }

        public void AddFilter() { }

        public void RemoveFilter() { }
    }
}

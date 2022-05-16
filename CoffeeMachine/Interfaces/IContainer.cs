using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Interfaces
{
    public interface IContainer
    {
        int MinAmount { get; }
        int MaxAmount { get; }
        int ActualAmount { get; }

        void FillContainer();
    }
}

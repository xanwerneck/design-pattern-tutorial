using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTutorial.Strategy.Methods
{
    public class CreditCard : IMethodPayment
    {
        private readonly double fee = 5.2;
        public double YouShouldReceive(double _paidValue)
        {
            return _paidValue - (_paidValue * (this.fee / 100.0));
        }
    }
}

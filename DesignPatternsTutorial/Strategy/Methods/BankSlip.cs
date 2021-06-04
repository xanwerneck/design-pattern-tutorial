using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTutorial.Strategy.Methods
{
    public class BankSlip : IMethodPayment
    {
        private readonly double fee = 2.5;
        public double YouShouldReceive(double _paidValue)
        {
            return _paidValue - (_paidValue * (this.fee / 100.0));
        }
    }
}

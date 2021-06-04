using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTutorial.Strategy
{
    public class Payment
    {
        protected double _paidValue { get; set; }
        private IMethodPayment _method;
        public Payment(IMethodPayment method, double value)
        {
            _method    = method;
            _paidValue = value;
        }
        public double YouShouldReceive()
        {
            return this._method.YouShouldReceive(this._paidValue);
        }
        public void ChangeMethod(IMethodPayment method)
        {
            _method = method;
        }
    }
}

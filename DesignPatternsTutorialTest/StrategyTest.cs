using System;
using Xunit;
using DesignPatternsTutorial.Strategy;
using DesignPatternsTutorial.Strategy.Methods;

namespace DesignPatternsTutorialTest
{
    public class StrategyTest
    {
        [Fact]
        public void Start()
        {
            Payment _payment = new Payment(new CreditCard(), 100);
            Assert.Equal(100 - 5.2, _payment.YouShouldReceive(), 2);
            _payment = new Payment(new BankSlip(), 100);
            Assert.Equal(100 - 2.5, _payment.YouShouldReceive(), 2);
            _payment.ChangeMethod(new CreditCard());
            Assert.Equal(100 - 5.2, _payment.YouShouldReceive(), 2);
        }
    }
}

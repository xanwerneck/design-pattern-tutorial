using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTutorial.ChainOfResponsibility.Handlers
{
    public class Participation : Certificate
    {
        public override object Emit(Inscription inscription)
        {
            if (inscription.Status != "Paid")
            {
                return "Inscription not paid";
            }
            return base.Emit(inscription);
        }
    }
}

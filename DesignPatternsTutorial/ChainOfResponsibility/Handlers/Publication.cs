using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTutorial.ChainOfResponsibility.Handlers
{
    public class Publication : Certificate
    {
        public override object Emit(Inscription inscription)
        {
            if (inscription.Papers.Count > 0)
            {
                return "Published content - " + base.Emit(inscription);
            }
            return base.Emit(inscription);
        }
    }
}

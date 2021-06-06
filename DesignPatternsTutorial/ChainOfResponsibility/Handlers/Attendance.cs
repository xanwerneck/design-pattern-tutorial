using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTutorial.ChainOfResponsibility.Handlers
{
    public class Attendance : Certificate
    {
        private float Total = 10;
        public override object Emit(Inscription inscription)
        {
            if (inscription.Watched < (Total * 0.7))
            {
                return "Only " + ((inscription.Watched / Total) * 100.0).ToString("N0") + "% watched";
            }
            return base.Emit(inscription);
        }
    }
}

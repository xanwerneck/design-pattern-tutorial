using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTutorial.ChainOfResponsibility
{
    public interface ICertificate
    {
        void setNext(ICertificate handler);
        object Emit(Inscription inscription);
    }
}

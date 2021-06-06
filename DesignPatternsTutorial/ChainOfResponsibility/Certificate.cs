using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTutorial.ChainOfResponsibility
{
    abstract public class Certificate : ICertificate
    {
        private ICertificate _certificate { get; set; }
        public virtual object Emit(Inscription inscription)
        {
            if(_certificate != null)
            {
                return _certificate.Emit(inscription);
            }
            else
            {
                return "Success emiting certificate";
            }
        }

        public void setNext(ICertificate certificate)
        {
            _certificate = certificate;
        }
    }
}

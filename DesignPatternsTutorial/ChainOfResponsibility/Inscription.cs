using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTutorial.ChainOfResponsibility
{
    public class Inscription
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Value { get; set; }
        public List<string> Papers { get; set; }
        public string Status { get; set; }
        public int Watched { get; set; }
    }
}

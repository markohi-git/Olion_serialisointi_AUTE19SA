using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Olion_serialisointi_AUTE19SA
{
    public class Viesti
    {
      
        public int kuitattu { get; set; } = 0; //0=default
        public string lahettaja { get; set; }
        public string vastaanottaja { get; set; }
        public string viesti { get; set; }
    }
}
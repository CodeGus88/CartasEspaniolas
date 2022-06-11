using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasEspaniolasApp.models
{
    public class Carta
    {
        public byte numero { get; set; }

        public String palo { get; set; }

        public Carta(byte numero, String palo)
        {
            this.numero = numero;
            this.palo = palo;
        }

    }
    
}

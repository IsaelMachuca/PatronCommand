using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCommand.Receiver
{
    public class Receptor
    {
        public void MayusculasActivadas ( bool mayus, char tecla)
        {
            Console.WriteLine
                (
                mayus ? $"Receptor: La siguiente tecla {tecla} sera mayuscula" : "Receptor: (mayus) No voy a interferir"
                );
        }
        public void NumLockActivado(bool mayus, char tecla)
        {
            Console.WriteLine
                (
                mayus ? "El siguiente numero de numpad sera registrado": "Receptor: (numlock) no voy a interferir"
                );
        }

        internal void NumLockActivadas(bool numlock)
        {
            Console.WriteLine(numlock ? "receptor: el siguiente numero de numpad sera registrado" : "receptor:(numlock)no voy a interferir");
        }
    }
}

using PatronCommand.Command.interfaces;
using PatronCommand.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCommand.Command
{
    public class ComandoComplejo : IComando
    {
        private bool _mayus, _numlock;
        private Receptor _receptor;
        public ComandoComplejo(bool mayus, bool numlock, Receptor receptor)
        {
            _mayus = mayus;
            _numlock = numlock;
            _receptor = receptor;
        }

        public void Ejecutar()
        {
            Console.WriteLine("Comando Complejo: Introduzca la tecla presionada....");
            char keycap = Console.ReadLine().FirstOrDefault();
            Console.WriteLine($"comando complejo: Vamos a ver si la tecla {keycap} sera afectada");
            this._receptor.MayusculasActivadas(_mayus, keycap);
            this._receptor.NumLockActivadas(_numlock);
        }
    }
}

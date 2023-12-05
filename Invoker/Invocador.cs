using PatronCommand.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCommand.Invoker
{
    public class Invocador
    {
        private IComando _alInicio;
        private IComando _alFinal;

        public void AlInicio(IComando command)
        {
            _alInicio = command;
        }
        public void AlFinal(IComando command)
        {
            _alFinal = command;
        }
        public void TecladoDigital()
        {
            Console.WriteLine("Invocador: Ocupo mostrar alfo antes de empezar?");
            if( this._alInicio is IComando)
            {
                this._alInicio.Ejecutar();
            }
            Console.WriteLine("Invocador: Ocupo mostrar alfo antes de empezar?");
            if (this._alFinal is IComando)
            {
                this._alFinal.Ejecutar();
            }
        }
    }
}

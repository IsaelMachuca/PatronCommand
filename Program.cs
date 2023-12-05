using PatronCommand.Command;
using PatronCommand.Invoker;
using PatronCommand.Receiver;



bool Mayusculas = true;
bool BloqNum = false;
Invocador invocador = new Invocador();
invocador.AlInicio(new ComandoSimple(Mayusculas, BloqNum));

Receptor receptor = new Receptor();
invocador.AlFinal ( new ComandoComplejo(Mayusculas,BloqNum,receptor));

invocador.TecladoDigital();
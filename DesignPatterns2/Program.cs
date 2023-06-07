// See https://aka.ms/new-console-template for more information

using DesignPatterns2.Memento;


Historico historico = new Historico();

Contrato c = new Contrato(DateTime.Now, "Gabriel", TipoContrato.Novo);
historico.Adiciona(c.SalvaEstado());

c.Avanca();
historico.Adiciona(c.SalvaEstado());

c.Avanca();
historico.Adiciona(c.SalvaEstado());

Console.WriteLine(c.TipoContrato);
Console.WriteLine(historico.Pega(0).Contrato.TipoContrato);
Console.WriteLine(historico.Pega(1).Contrato.TipoContrato);


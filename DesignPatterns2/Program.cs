// See https://aka.ms/new-console-template for more information

using DesignPatterns2.Adapter;
using DesignPatterns2.Command;
using DesignPatterns2.Memento;

/* Memento
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


Order order = new Order("Gabriel", 100.0);
WorkQueue workQueue = new WorkQueue();

Console.WriteLine(order.Status);

workQueue.AddProcess(new Payment(order));
workQueue.AddProcess(new FinalizeOrder(order));
workQueue.Process();
Console.WriteLine(order.Status);

*/

Costumer costumer = new Costumer {
    Name = "Gabriel",
    Adress = "Rua B"
};

string xml = new XmlGenerator().GenerateXml(costumer);
Console.WriteLine(xml);
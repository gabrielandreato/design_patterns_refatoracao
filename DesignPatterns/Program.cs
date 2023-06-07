using DesignPatterns.DesignPatterns1;
using DesignPatterns.DesignPatterns1.AplicaDesconto;


var orcamento = new Orcamento(500);

Console.WriteLine(orcamento.Valor);

orcamento.Aprova();

orcamento.AplicaDescontoExtra();

Console.WriteLine(orcamento.Valor);
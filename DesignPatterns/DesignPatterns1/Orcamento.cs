using DesignPatterns.DesignPatterns1.AplicaDesconto;

namespace DesignPatterns.DesignPatterns1;

public class Orcamento{
    public double Valor { get; set; }
    public IList<Item> Itens { get; set; }

    public EstadoDeUmOrcamento EstadoAtual { get; set; }
    public Orcamento(double valor) {
        this.Valor = valor;
        this.Itens = new List<Item>();
        this.EstadoAtual = new EmAprovacao();
    }

    public void AplicaDescontoExtra() {
        EstadoAtual.AplicaDescontoExtra(this);
    }
    
    public void AdicionaItem(Item item) {
        this.AdicionaItem(item);
    }

    public void Aprova() {
        EstadoAtual.Aprova(this);
    }
}
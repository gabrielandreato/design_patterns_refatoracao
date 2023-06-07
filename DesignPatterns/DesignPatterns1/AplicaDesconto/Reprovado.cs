namespace DesignPatterns.DesignPatterns1.AplicaDesconto;

public class Reprovado: EstadoDeUmOrcamento{
    public void AplicaDescontoExtra(Orcamento orcamento) {
        orcamento.Valor = orcamento.Valor;
    }
    public void Aprova(Orcamento orcamento) {
        orcamento.EstadoAtual = new Aprovado();
    }

    public void Reprova(Orcamento orcamento) {
        orcamento.EstadoAtual = new Reprovado();
    }
}
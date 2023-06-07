namespace DesignPatterns.DesignPatterns1.AplicaDesconto;

public class Aprovado: EstadoDeUmOrcamento{
    
    public void AplicaDescontoExtra(Orcamento orcamento) {
        orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.1);
    }
    
    public void Aprova(Orcamento orcamento) {
        orcamento.EstadoAtual = new Aprovado();
    }

    public void Reprova(Orcamento orcamento) {
        orcamento.EstadoAtual = new Reprovado();
    }
}
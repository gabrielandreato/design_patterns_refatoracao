namespace DesignPatterns.DesignPatterns1.AplicaDesconto;

public interface EstadoDeUmOrcamento{
    void AplicaDescontoExtra(Orcamento orcamento);

    void Aprova(Orcamento orcamento);
    void Reprova(Orcamento orcamento);
}
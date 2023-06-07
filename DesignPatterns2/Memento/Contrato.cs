namespace DesignPatterns2.Memento; 

public class Contrato {
    public DateTime Data { get; private set; }
    public string Cliente { get; private set; }
    public TipoContrato TipoContrato { get; private set; }

    public Contrato(DateTime date,  string cliente, TipoContrato tipoContrato) {
        Data = date;
        Cliente = cliente;
        TipoContrato = tipoContrato;
    }

    public void Avanca() {
        if (TipoContrato == TipoContrato.Novo) TipoContrato = TipoContrato.EmAndamento;
        else if (TipoContrato == TipoContrato.EmAndamento) TipoContrato = TipoContrato.Acertado;
        else if (TipoContrato == TipoContrato.Acertado) TipoContrato = TipoContrato.Concluido;
    }

    public Estado SalvaEstado() {
        return new Estado(new Contrato(Data, Cliente, TipoContrato));
    }
}
using System.Runtime.InteropServices;

namespace DesignPatterns2.Command; 

public class Order {
    public string Name { get; set; }
    public double Value { get; set; }
    public DateTime FinalizationDate { get; set; }
    public Status Status { get; set; }

    public Order(string name, double value) {
        Name = name;
        Value = value;
        Status = Status.Novo;
    }

    public void Pay() {
        Status = Status.Pago;
    }

    public void Finalize() {
        Status = Status.Finalizado;
        FinalizationDate = DateTime.Now;
    }
}
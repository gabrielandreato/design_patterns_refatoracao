namespace DesignPatterns2.Command; 

public class FinalizeOrder: ICommand {

    public Order Order { get; set; }

    public FinalizeOrder(Order order) {
        Order = order;
    }
    public void Execut() {
        Order.Finalize();
    }
}
namespace DesignPatterns2.Command; 

public class Payment: ICommand {

    private Order Order { get; set; }

    public Payment(Order order) {
        Order = order;
    }

    public void Execut() {
        Order.Pay();
    }
    
    
}
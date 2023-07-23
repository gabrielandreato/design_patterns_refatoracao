namespace DesignPatterns2.Command; 

public class WorkQueue {
    public List<ICommand> Commands = new List<ICommand>();

    public void AddProcess(ICommand command) {
        Commands.Add(command);
    }

    public void Process() {
        foreach (var item in Commands) {
            item.Execut();
        }
    }
}
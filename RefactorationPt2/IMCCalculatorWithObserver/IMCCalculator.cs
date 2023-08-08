namespace RefactorationPt2.IMCCalculatorWithObserver;

public interface ICalculatorObserver {
    void ResultadoIMC(double imc);
}

public class IMCCalculator: ICalculatorObserver {
    private IList<ICalculatorObserver> observers = new List<ICalculatorObserver>();

    private IMCCalculator calculator;
    
    public IMCCalculator() {
        calculator = new IMCCalculator();
        calculator.Adicionar(this);
    }
    
    public void Calcular(int peso, int altura) {

        double imc = peso / (altura * altura);
        
        foreach (var observer in observers) {
            observer.ResultadoIMC(imc);
        }
        
    }
    
    public void Adicionar(ICalculatorObserver observer) {
        observers.Add(observer);
    }

    public void Remove(ICalculatorObserver observer) {
        observers.Remove(observer);
    }

    public void ResultadoIMC(double imc) {
        Console.WriteLine($"Seu imc é de: " + imc);
    }
}
using System.Security.AccessControl;

namespace RefactorationPt2.StateStrategyImplementation;

public class Funcionario {
    public decimal Salario { get; private set; }
    public decimal Comissao { get; private set; }
    public decimal Bonus { get; private set; }
    private ITipoFuncionario Tipo { get; set; }

    public Funcionario(decimal salario, ITipoFuncionario tipo, decimal? comissao = 0, decimal? bonus = 0) {
        Salario = salario;
        Tipo = tipo;
        Comissao = comissao ?? 0;
        Bonus = bonus ?? 0;
    }

    public decimal GetPagamento() {
        return Tipo.GetPagamento(this);
    }
    
}
public interface ITipoFuncionario {
    public decimal GetPagamento(Funcionario funcionario) {
        return funcionario.Salario;
    }
}


public class Engenheiro: ITipoFuncionario {

}

public class Vendedor: ITipoFuncionario{
    public decimal GetPagamento(Funcionario funcionario) {
        return funcionario.Salario + funcionario.Comissao;
    }
    
}

public class Gerente: ITipoFuncionario {
    public decimal GetPagamento(Funcionario funcionario) {
        return funcionario.Salario + funcionario.Bonus;
    }
    
}
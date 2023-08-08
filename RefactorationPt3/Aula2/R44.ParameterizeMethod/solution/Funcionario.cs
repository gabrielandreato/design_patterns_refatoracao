using RefactorationPt3.Aula1;

namespace RefactorationPt3.Aula2.R44.ParameterizeMethod.solution
{
    class ParameterizeMethod: IRefactoration
    {
        public void Execute()
        {
            var funcionario1 = new Funcionario("Tony Estarque", 10000);
            var funcionario2 = new Funcionario("Pedro Parques", 2000);

            funcionario1.DarAumento(5);
            funcionario2.DarAumento(10);
        }
    }

    class Funcionario
    {
        readonly string nome;
        public string Nome => nome;

        decimal salario;
        public decimal Salario => salario;

        public Funcionario(string nome, decimal salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public void DarAumento(decimal aumento) {
            salario *= 1.0m + (aumento / 100.0m);
        }
    }
}

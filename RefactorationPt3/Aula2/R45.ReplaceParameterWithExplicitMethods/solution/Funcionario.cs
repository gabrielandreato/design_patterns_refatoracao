using RefactorationPt3.Aula1;

namespace RefactorationPt3.Aula2.R45.ReplaceParameterWithExplicitMethods.solution
{
    class ReplaceParameterWithExplicitMethods: IRefactoration
    {
        public void Execute()
        {
            var funcionario1 = new Funcionario("Tony Estarque", 10000);
            var funcionario2 = new Funcionario("Pedro Parques", 2000);

            funcionario1.DarAumentoFixo(3000);
            funcionario2.DarAumentoPercentual(10);
            Console.WriteLine(funcionario1.Salario);
            Console.WriteLine(funcionario2.Salario);
        }
    }

    class Funcionario
    {
        public const int TIPO_AUMENTO_FIXO = 0;
        public const int TIPO_AUMENTO_PORCENTUAL = 1;

        readonly string nome;
        public string Nome => nome;

        decimal salario;
        public decimal Salario => salario;

        public Funcionario(string nome, decimal salario)
        {
            this.nome = nome;
            this.salario = salario;
        }
        

        public void DarAumentoFixo(decimal aumento) {
            salario += aumento;
        }

        public void DarAumentoPercentual(decimal aumento) {
            salario *= (1.0m + aumento / 100.0m);
        }
    }
}

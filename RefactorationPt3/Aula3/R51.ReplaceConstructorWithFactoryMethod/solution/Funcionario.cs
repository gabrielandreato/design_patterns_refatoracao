using RefactorationPt3.Aula1;

namespace RefactorationPt3.Aula3.R51.ReplaceConstructorWithFactoryMethod.solution
{
    class ReplaceConstructorWithFactoryMethod: IRefactoration
    {
        public void Execute()
        {
            Funcionario funcionario = Funcionario.CriarGerente("José da Silva", 1000);
            Console.WriteLine($"Funcionario {funcionario.Nome} do tipo {funcionario.Tipo} criado com sucesso!");
        }
    }

    enum TipoFuncionario
    {
        Vendedor = 0,
        Gerente = 1,
        Engenheiro = 2
    }

    class Funcionario
    {

        readonly TipoFuncionario tipo;
        public TipoFuncionario Tipo => tipo;

        readonly string nome;
        public string Nome => nome;

        readonly decimal salario;
        public decimal Salario => salario;

        public Funcionario(TipoFuncionario tipo, string nome, decimal salario)
        {
            this.tipo = tipo;
            this.nome = nome;
            this.salario = salario;

            LancarRegistrosNoBancoDeDados();
            GerarDocumentosFiscais();
            EnviarEmailDeBoasVindas();

        }

        public static Funcionario CriarVendedor(string nome, decimal salario) {
            var funcionario = new Funcionario(TipoFuncionario.Engenheiro, nome, salario);
            funcionario.GerarRegistroDeComissao();
            return funcionario;
        }

        public static Funcionario CriarGerente(string nome, decimal salario) {
            var funcionario = new Funcionario(TipoFuncionario.Vendedor, nome, salario);
            funcionario.GerarRegistroDeBonus();
            return funcionario;
        }

        private void GerarRegistroDeBonus()
        {
            //método criado apenas para ilustração
        }

        private void GerarRegistroDeComissao()
        {
            //método criado apenas para ilustração
        }

        private void EnviarEmailDeBoasVindas()
        {
            //método criado apenas para ilustração
        }

        private void GerarDocumentosFiscais()
        {
            //método criado apenas para ilustração
        }

        private void LancarRegistrosNoBancoDeDados()
        {
            //método criado apenas para ilustração
        }
    }
}

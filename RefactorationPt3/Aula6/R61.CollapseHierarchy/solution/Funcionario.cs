using RefactorationPt3.Aula1;

namespace RefactorationPt3.Aula6.R61.CollapseHierarchy.solution
{
    class CollapseHierarchy: IRefactoration
    {
        public void Execute()
        {
            var empregado = new Funcionario("Walter White", "555-12345", "666-65432");
            Console.WriteLine(empregado);
        }
    }

    class Funcionario
    {
        public string Nome { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }

        public Funcionario(string nome, string telefoneFixo, string celular)
        {
            Nome = nome;
            TelefoneFixo = telefoneFixo;
            Celular = celular;
        }
    }
}

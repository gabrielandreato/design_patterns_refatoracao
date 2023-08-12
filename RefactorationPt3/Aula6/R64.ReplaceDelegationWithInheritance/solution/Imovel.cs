namespace RefactorationPt3.Aula6.R64.ReplaceDelegationWithInheritance.solution
{
    class ReplaceDelegationWithInheritance
    {
        public void Execute()
        {
            var imovel = 
                new Apartamento("Rua dos Bobos, No. 0", 100000, 200);
        }
    }

    abstract class Imovel
    {
        public string Endereco { get; set; }
        public decimal ValorImovel { get; set; }

        protected Imovel(string endereco, decimal valorImovel)
        {
            Endereco = endereco;
            ValorImovel = valorImovel;
        }
    }

    class Apartamento: Imovel
    {
        private decimal ValorCondominio { get; set; }
        public Apartamento(string endereco, decimal valorImovel, decimal valorCondominio)
            : base(endereco, valorImovel) {
            ValorCondominio = valorCondominio;
        }
    }
}

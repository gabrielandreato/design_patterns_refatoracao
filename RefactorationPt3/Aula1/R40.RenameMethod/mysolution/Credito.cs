namespace RefactorationPt3.Aula1.R40.RenameMethod.mysolution
{
    class RenamingMethodCredito: IRefactoration
    {
        public void Execute()
        {
            var costumer1 = new PessoaFisica("Walter White", new Credito(10000, 9700));
            var costumer2 = new PessoaJuridica("Los Pollos Hermanos", new Credito(20000, 15000));

            var costumerList = new List<IPerson>() {
                costumer1, costumer2
            };

            foreach (IPerson costumer in costumerList) {
                Console.WriteLine($"Crédito disponível - Nome: {costumer.GetNome()}, " +
                                  $"Valor: {costumer.GetCreditoDisponivel()}");
            }
        }
    }

    class PessoaFisica: IPerson
    {
        private readonly string nome;

        public string GetNome()
        {
            return nome;
        }

        private readonly Credito credito;
        internal Credito Credito => credito;

        public PessoaFisica(string nome, Credito credito)
        {
            this.nome = nome;
            this.credito = credito;
        }

        public decimal GetCreditoDisponivel()
        {
            return credito.GetValor();
        }
    }

    class PessoaJuridica: IPerson
    {
        private readonly string nome;

        public string GetNome()
        {
            return nome;
        }

        private readonly Credito credito;
        internal Credito Credito => credito;

        public PessoaJuridica(string nome, Credito credito)
        {
            this.nome = nome;
            this.credito = credito;
        }

        public decimal GetCreditoDisponivel()
        {
            return credito.GetValor();
        }
    }

    class Credito
    {
        readonly decimal creditoTotal;
        public decimal CreditoTotal => creditoTotal;

        readonly decimal creditoUtilizado;
        public decimal CreditoUtilizado => creditoUtilizado;

        public Credito(decimal creditoTotal, decimal creditoUtilizado)
        {
            this.creditoTotal = creditoTotal;
            this.creditoUtilizado = creditoUtilizado;
        }

        public decimal GetValor()
        {
            //Obtém o valor do crédito disponível
            return this.creditoTotal - this.creditoUtilizado;
        }
    }
}

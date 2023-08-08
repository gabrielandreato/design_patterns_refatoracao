namespace RefactorationPt3.Aula1.R41.AddParameter.solucao
{
    class PricesCalculatorIncludingParameter: IRefactoration
    {
        public void Execute()
        {
            var descontoCliente1 =
                new CalculadoraDePrecos()
                .GetDescontoFinal(23, 10, 3, false);

            Console.WriteLine($"Desconto final: {descontoCliente1}");

            var descontoCliente2 =
                new CalculadoraDePrecos()
                .GetDescontoFinal(30, 4, 5, true); //Mas este cliente é negativado!

            Console.WriteLine($"Desconto final: {descontoCliente2}");
        }
    }

    class CalculadoraDePrecos
    {
        private const decimal LIMITE_MAXIMO_DESCONTO_INICIAL = 50m;
        private const int LIMITE_MINIMO_QUANTIDADE = 100;
        private const int LIMITE_MINIMO_ANOS_CLIENTE = 4;
        private const decimal DESCONTO_MAXIMO = 50m;
        private const decimal INCREMENTO_DESCONTO_POR_QUANTIDADE = 15m;
        private const decimal INCREMENTO_DESCONTO_POR_TEMPO = 10m;


        public decimal GetDescontoFinal(decimal descontoInicial, int quantidade, int clienteHaQuantosAnos, bool restricaoFinanceira) {
            if (restricaoFinanceira) return 0;
            var result = descontoInicial;
            if (descontoInicial > LIMITE_MAXIMO_DESCONTO_INICIAL)
            {
                result = DESCONTO_MAXIMO;
            }
            if (quantidade > LIMITE_MINIMO_QUANTIDADE)
            {
                result += INCREMENTO_DESCONTO_POR_QUANTIDADE;
            }
            if (clienteHaQuantosAnos > LIMITE_MINIMO_ANOS_CLIENTE)
            {
                result += INCREMENTO_DESCONTO_POR_TEMPO;
            }
            return result;
        }
    }
}

namespace RefactorationPt3.Aula3.R49.RemoveSettingMethod.solution
{
    class ContaCorrente
    {
        private static int ultimoId = 0;
        private int id;
        private decimal saldo;

        public ContaCorrente(decimal saldo)
        {
            this.id = GetNewId();
            this.saldo = saldo;
        }

        private static int GetNewId()
        {
            return ultimoId++;
        }

        private void Depositar(decimal valor)
        {
            saldo += valor;
        }

        private void Sacar (decimal valor)
        {
            if (valor > saldo)
            {
                throw new ArgumentException("Saldo insuficiente.");
            }
            saldo -= valor;
        }
    }
}

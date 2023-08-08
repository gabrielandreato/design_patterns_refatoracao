using RefactorationPt3.Aula1;

namespace RefactorationPt3.Aula3.R53.ReplaceExceptionwithTest.solution {
    class ReplaceExceptionWithTest : IRefactoration {
        public void Execute() {
            var contaCorrente = new ContaCorrente(1000);

            var saldoInicialAnoAtual = contaCorrente.GetSaldoInicioAno(DateTime.Now.Year);
        }
    }

    class ContaCorrente {
        private static int ultimoId = 0;
        private int id;
        private decimal saldo;

        private IDictionary<int, decimal> saldosIniciais
            = new Dictionary<int, decimal>();

        public ContaCorrente(decimal saldo) {
            this.id = GetNewId();
            this.saldo = saldo;

            RegistrarSaldo();
        }


        private static int GetNewId() {
            return ultimoId++;
        }

        private void Depositar(decimal valor) {
            saldo += valor;
            RegistrarSaldo();
        }

        private void Sacar(decimal valor) {
            if (valor > saldo) {
                throw new ArgumentException("Saldo insuficiente.");
            }

            saldo -= valor;
            RegistrarSaldo();
        }

        private void RegistrarSaldo() {
            if (!this.saldosIniciais.ContainsKey(DateTime.Now.Year)) {
                this.saldosIniciais.Add(DateTime.Now.Year, this.saldo);
            }
        }

        public decimal GetSaldoInicioAno(int ano) {
            return !saldosIniciais.ContainsKey(ano) ? 0 : saldosIniciais[ano];
        }
    }
}
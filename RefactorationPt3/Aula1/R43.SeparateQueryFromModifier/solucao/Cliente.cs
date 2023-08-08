namespace RefactorationPt3.Aula1.R43.SeparateQueryFromModifier.solucao {
    public class ClienteSeparateQueryFromModifier : IRefactoration {
        public void Execute() {
            IList<NotaFiscal> lstNotasFiscais = new List<NotaFiscal> {
                new(1, 5000),
                new(2, 1000),
                new(3, 2000),
                new(4, 7000),
                new(5, 2000)
            };

            Cliente cliente = new Cliente();
            cliente.Adicionar(lstNotasFiscais);
            cliente.VerificarNotasFiscais();
        }
    }

    class NotaFiscal {
        readonly int id;
        public int Id => id;

        readonly decimal valor;
        public decimal Valor => valor;

        public NotaFiscal(int id, decimal valor) {
            this.id = id;
            this.valor = valor;
        }
    }

    class Cliente {
        private List<NotaFiscal> notasFiscais = new();

        internal void Adicionar(IList<NotaFiscal> notasFiscais) {
            this.notasFiscais.AddRange(notasFiscais);
        }

        public void VerificarNotasFiscais() {
            NotaFiscal nf = ObterNFPremium(notasFiscais);
            if (nf != null) {
                CriarCartaoPremium(nf);
                EnviarEmailParabens(nf);
            }
        }

        public NotaFiscal ObterNFPremium(IList<NotaFiscal> notasFiscais) {
            foreach (var nf in notasFiscais) {
                if (nf.Valor > 10000) {
                    return nf;
                }
            }

            return null;
        }

        private void CriarCartaoPremium(NotaFiscal nf) {
            //código para criar cartão de cliente premium
        }

        private void EnviarEmailParabens(NotaFiscal nf) {
            string mensagem =
                "Prezado Cliente, " +
                "Parabéns! Você se tornou Cliente Premium " +
                "e receberá em breve um cartão exclusivo da nossa loja! " +
                "" +
                "Atenciosamente, " +
                "" +
                "A Sua Loja" +
                "http://asualojamaislegal.com.br";

            //aqui vai o código para enviar o email
        }
    }
}
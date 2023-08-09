using RefactorationPt3.Aula1;

namespace RefactorationPt3.Aula5.R58.ExtractSubclass.solution {
    class ExtractSubclass : IRefactoration {
        public void Execute() {
            Funcionario joao = new Funcionario(50);
            ItemDeServico s1 = new MaoDeObra(5, 0, joao);
            ItemDeServico s2 = new MateriaPrima(15, 10);
            decimal totalDoServico = s1.GetPrecoTotal() + s2.GetPrecoTotal();
        }
    }

    abstract class ItemDeServico {
        private int quantidade;


        public ItemDeServico(int quantidade, decimal precoUnitario) {
            this.quantidade = quantidade;
        }

        public decimal GetPrecoTotal() {
            return quantidade * GetPrecoUnitario();
        }

        protected abstract decimal GetPrecoUnitario();

        public int GetQuantidade() {
            return quantidade;
        }
    }

    class MateriaPrima : ItemDeServico {
        private decimal precoUnitario;

        public MateriaPrima(int quantidade, decimal precoUnitario)
            : base(quantidade, precoUnitario) {
        }

        protected override decimal GetPrecoUnitario() {
            return precoUnitario;
        }
    }

    class MaoDeObra : ItemDeServico {
        private Funcionario funcionario;

        public MaoDeObra(int quantidade, decimal precoUnitario, Funcionario funcionario)
            : base(quantidade, precoUnitario) {
            this.funcionario = funcionario;
        }

        protected override decimal GetPrecoUnitario() {
            return funcionario.GetCusto();
        }

        public Funcionario GetFuncionario() {
            return funcionario;
        }
    }

    class Funcionario {
        private decimal custo;

        public Funcionario(decimal custo) {
            this.custo = custo;
        }

        public decimal GetCusto() {
            return custo;
        }
    }
}
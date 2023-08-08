using RefactorationPt3.Aula1;

namespace RefactorationPt3.Aula2.R48.IntroduceParameterObject.solution
{
    class IntroduceParameterObject: IRefactoration
    {
        public void Execute()
        {
            var hotel = new HotelFazenda(500, 200, 800);
            var valor5DiasNoVerao = hotel.GetValorTotal(new Periodo(new DateTime(2018, 1, 1), new DateTime(2018, 1, 6)) );
            var valor7DiasAposVerao = hotel.GetValorTotal(new Periodo(new DateTime(2018, 4, 1), new DateTime(2018, 4, 8)) );

            Console.WriteLine(valor5DiasNoVerao);
            Console.WriteLine(valor7DiasAposVerao);
        }
    }

    class Periodo {
        public DateTime Inicio { get; }
        public DateTime Fim { get; }

        public Periodo(DateTime inicio, DateTime fim) {
            this.Inicio = inicio;
            this.Fim = fim;

            if ((fim - this.Inicio).TotalDays < 0) {
                throw new ArgumentException("Data fim menor que data e inicio");
            }
        }

        public int Dias() {
            return (int)(Fim - Inicio).TotalDays;
        } 
    }

    class HotelFazenda
    {
        private decimal _taxaInverno;
        private decimal _taxaServicoInverno;
        private decimal _taxaVerao;

        public HotelFazenda(decimal taxaInverno, decimal taxaServicoInverno, decimal taxaVerao)
        {
            _taxaInverno = taxaInverno;
            _taxaServicoInverno = taxaServicoInverno;
            _taxaVerao = taxaVerao;
        }

        private DateTime INICIO_VERAO = new DateTime(2017, 12, 23);
        private DateTime FIM_VERAO = new DateTime(2018, 03, 21);

        public decimal GetValorTotal(Periodo periodo)
        {
            var dias = (int)(periodo.Fim - periodo.Inicio).TotalDays;

            if (NaoEhVerao(periodo.Inicio))
                return TaxaInverno(dias);

            return TaxaVerao(dias); //early return
        }

        private decimal TaxaVerao(int dias)
        {
            return dias * _taxaVerao;
        }

        private decimal TaxaInverno(int dias)
        {
            return dias * _taxaInverno + _taxaServicoInverno;
        }

        private bool NaoEhVerao(DateTime data)
        {
            return data.EhAntesDe(INICIO_VERAO) || data.EhDepoisDe(FIM_VERAO);
        }
    }

    static class DateTimeExtensions
    {
        public static bool EhAntesDe(this DateTime estaData, DateTime aquelaData)
        {
            return DateTime.Compare(aquelaData, estaData) < 0;
        }

        public static bool EhDepoisDe(this DateTime estaData, DateTime aquelaData)
        {
            return DateTime.Compare(aquelaData, estaData) > 0;
        }
    }

}

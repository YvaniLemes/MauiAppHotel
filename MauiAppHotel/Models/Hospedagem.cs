namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut { get; set; }

        public int Estadia
        {
            get
            {
                if (DateCheckOut <= DateCheckIn) return 0;
                return (DateCheckOut - DateCheckIn).Days;
            }
        }

        public double ValorTotal
        {
            get
            {
                if (QuartoSelecionado == null) return 0; // evita NullReferenceException
                var valorAdultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                var valorCriancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;
                return (valorAdultos + valorCriancas) * Estadia;
            }
        }
    }
}
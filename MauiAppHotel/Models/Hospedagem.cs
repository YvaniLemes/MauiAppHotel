namespace MauiAppHotel.Models
{ 
    public class Hospedagem
{
    public Quarto QuartoSelecionado {  get; set; }
        public int QntAdultos {  get; set; }
        public int QntCriancas {  get; set; }
        public DateTime DateCheckIn {  get; set; }
        public DateTime DateCheckOut {  get; set; }
        public int Estadia
        {
            get => DateCheckOut.Subtract(DateCheckIn).Days;
        }
    public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCriança;
                
                double total = (valor_adultos + valor_criancas) * Estadia;

                return total;
            }
        }
    }
}

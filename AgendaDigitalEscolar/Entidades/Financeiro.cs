namespace Entidades
{
    public class Financeiro
    {
        public int FinanceiroId { get; set; }
        public int EstudanteId { get; set; }
        public Estudante Estudante { get; set; }
        public int Mes { get; set; }
        public bool Pago { get; set; } = false;
    }
}

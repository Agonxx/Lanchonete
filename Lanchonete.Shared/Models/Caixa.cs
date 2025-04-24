namespace Lanchonete.Shared.Models
{
    public class Caixa
    {
        public int Id { get; set; }
        public DateTime DataAbertura { get; set; } = DateTime.Now;
        public DateTime? DataEncerramento { get; set; }
    }

    public class CaixaApi
    {
        public const string BuscarCaixas = nameof(BuscarCaixas);
    }
}

using Lanchonete.Shared.Enums;

namespace Lanchonete.Shared.Models
{
    public class Caixa
    {
        public int Id { get; set; }
        public string Descrição { get; set; }
        public ECaixaStatus Status { get; set; } = ECaixaStatus.Aberto;
        public DateTime DataAbertura { get; set; } = DateTime.Now;
        public DateTime? DataEncerramento { get; set; }
    }

    public class CaixaApi
    {
        public const string BuscarCaixas = nameof(BuscarCaixas);
        public const string BuscarPorCaixaId = nameof(BuscarPorCaixaId);
        public const string BuscarCaixaAberto = nameof(BuscarCaixaAberto);
    }

}

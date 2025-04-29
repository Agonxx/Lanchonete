using Lanchonete.Shared.Enums;

namespace Lanchonete.Shared.Dtos
{
    public class CaixaDto
    {
        public int Id { get; set; }
        public ECaixaStatus Status { get; set; } = ECaixaStatus.Aberto;
        public DateTime DataAbertura { get; set; } = DateTime.Now;
        public DateTime? DataEncerramento { get; set; }
        public List<PedidoDto> Pedidos { get; set; } = new();
    }
}

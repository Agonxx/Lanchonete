namespace Lanchonete.Shared.Dtos
{
    public class PedidoDto
    {
        public int Id { get; set; }
        public int CaixaId { get; set; }
        public decimal Valor { get; set; }
        public DateTime CadastradoEm { get; set; } = DateTime.Now;
    }
}

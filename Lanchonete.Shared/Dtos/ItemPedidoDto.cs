namespace Lanchonete.Shared.Dtos
{
    public class ItemPedidoDto
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime CadastradoEm { get; set; } = DateTime.Now;
    }

}

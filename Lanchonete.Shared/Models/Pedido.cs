namespace Lanchonete.Shared.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int CaixaId { get; set; }
        public decimal Valor { get; set; }
        public DateTime CadastradoEm { get; set; } = DateTime.Now;
    }

    public class PedidoApi
    {
        public const string Registrar = nameof(Registrar);
        public const string BuscarPedidos = nameof(BuscarPedidos);
    }
}

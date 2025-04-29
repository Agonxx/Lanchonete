namespace Lanchonete.Shared.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime CadastradoEm { get; set; } = DateTime.Now;
    }

    public class ProdutoApi
    {
        public const string BuscarProdutos = nameof(BuscarProdutos);
        public const string BuscarProdutoPorId = nameof(BuscarProdutoPorId);
    }
}

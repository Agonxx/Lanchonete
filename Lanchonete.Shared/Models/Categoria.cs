namespace Lanchonete.Shared.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime CadastradoEm { get; set; } = DateTime.Now;
    }

    public class CategoriaApi
    {
        public const string Cadastrar = "Cadastrar";
        public const string BuscarCategorias = "BuscarCategorias";
    }
}

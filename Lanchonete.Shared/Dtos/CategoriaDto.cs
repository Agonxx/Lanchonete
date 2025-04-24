namespace Lanchonete.Shared.Dtos
{
    public class CategoriaDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime CadastradoEm { get; set; } = DateTime.Now;
    }

}

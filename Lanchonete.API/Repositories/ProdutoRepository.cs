using Lanchonete.API.Database;
using Lanchonete.Shared.Dtos;
using Lanchonete.Shared.Enums;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete.API.Repositories
{
    public class ProdutoRepository
    {
        public readonly DBLanchonete _db;

        public ProdutoRepository(DBLanchonete db)
        {
            _db = db;
        }

        public async Task<List<ProdutoDto>> BuscarProdutos()
        {
            var listaProdutos = await (from prod in _db.Produtos
                                       select new ProdutoDto
                                       {
                                           Id = prod.Id,
                                           CategoriaId = prod.CategoriaId,
                                           Descricao = prod.Descricao,
                                           Valor = prod.Valor,
                                           CadastradoEm = prod.CadastradoEm
                                       }).ToListAsync();

            return listaProdutos;   
        }

        public async Task<ProdutoDto> BuscarProdutoPorId(int produtoId)
        {
            var produto = await (from prod in _db.Produtos
                                 where prod.Id == produtoId
                                 select new ProdutoDto
                                 {
                                     Id = prod.Id,
                                     CategoriaId = prod.CategoriaId,
                                     Descricao = prod.Descricao,
                                     Valor = prod.Valor,
                                     CadastradoEm = prod.CadastradoEm
                                 }).FirstOrDefaultAsync();

            return produto;
        }

    }
}

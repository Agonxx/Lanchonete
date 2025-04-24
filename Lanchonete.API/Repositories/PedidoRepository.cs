using Lanchonete.API.Database;
using Lanchonete.Shared.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete.API.Repositories
{
    public class PedidoRepository
    {
        public readonly DBLanchonete _db;

        public PedidoRepository(DBLanchonete db)
        {
            _db = db;
        }

        public async Task<List<PedidoDto>> BuscarPedidos()
        {
            var listaPedidos = await (from pedidos in _db.Pedidos
                                      select new PedidoDto
                                      {
                                          Id = pedidos.Id,
                                          CaixaId = pedidos.CaixaId,
                                          CadastradoEm  = pedidos.CadastradoEm,
                                          Valor = pedidos.Valor
                                      }).ToListAsync();

            return listaPedidos;
        }


    }
}

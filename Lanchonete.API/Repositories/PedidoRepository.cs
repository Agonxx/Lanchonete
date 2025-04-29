using Lanchonete.API.Database;
using Lanchonete.Shared.Dtos;
using Lanchonete.Shared.Models;
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
                                          CadastradoEm = pedidos.CadastradoEm,
                                          Valor = pedidos.Valor
                                      }).ToListAsync();

            return listaPedidos;
        }

        public async Task<List<PedidoDto>> BuscarPorCaixaId(int caixaId)
        {
            var listaPedidos = await (from pedidos in _db.Pedidos
                                      where pedidos.CaixaId == caixaId
                                      select new PedidoDto
                                      {
                                          Id = pedidos.Id,
                                          CaixaId = pedidos.CaixaId,
                                          CadastradoEm = pedidos.CadastradoEm,
                                          Valor = pedidos.Valor
                                      }).ToListAsync();

            return listaPedidos;
        }

        public async Task<bool> Registrar(PedidoDto pedidoObj)
        {
            Pedido novoPedido = new()
            {
                CaixaId = pedidoObj.CaixaId,
                Valor = pedidoObj.Itens.Select(w => w.Valor).Sum(),
                CadastradoEm = DateTime.Now,
            };

            _db.Pedidos.Add(novoPedido);
            await _db.SaveChangesAsync();

            List<ItemPedido> itenspedido = new();

            pedidoObj.Itens.ForEach(item =>
            {
                var novoItem = new ItemPedido()
                {
                    PedidoId = pedidoObj.Id,
                    Descricao = item.Descricao,
                    Valor = item.Valor,
                    CadastradoEm = DateTime.Now,
                    CategoriaId = item.CategoriaId,
                };
                itenspedido.Add(novoItem);
            });

            _db.ItensPedido.AddRange(itenspedido);
            await _db.SaveChangesAsync();

            return true;
        }

    }
}

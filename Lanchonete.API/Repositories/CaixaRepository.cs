using Lanchonete.API.Database;
using Lanchonete.Shared.Dtos;
using Lanchonete.Shared.Enums;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete.API.Repositories
{
    public class CaixaRepository
    {
        public readonly DBLanchonete _db;

        public CaixaRepository(DBLanchonete db)
        {
            _db = db;
        }

        public async Task<List<CaixaDto>> BuscarCaixas()
        {
            var listaCaixas = await (from caixas in _db.Caixas
                                     select new CaixaDto
                                     {
                                         Id = caixas.Id,
                                         DataAbertura = caixas.DataAbertura,
                                         DataEncerramento = caixas.DataEncerramento,
                                     }).ToListAsync();

            return listaCaixas;
        }

        public async Task<CaixaDto> BuscarCaixaAberto()
        {
            var caixaAberto = await (from caixas in _db.Caixas
                                     where caixas.Status == ECaixaStatus.Aberto
                                     select new CaixaDto
                                     {
                                         Id = caixas.Id,
                                         DataAbertura = caixas.DataAbertura,
                                         Status = caixas.Status,
                                     }).FirstOrDefaultAsync();
            if (caixaAberto == null)
                return caixaAberto;

            caixaAberto.Pedidos = await (from pedidos in _db.Pedidos
                                         where pedidos.CaixaId == caixaAberto.Id
                                         select new PedidoDto
                                         {
                                             Id = pedidos.Id,
                                             CaixaId = pedidos.CaixaId,
                                             CadastradoEm = pedidos.CadastradoEm,
                                             Valor = pedidos.Valor
                                         }).ToListAsync();

            return caixaAberto;
        }

        public async Task<List<CaixaDto>> BuscarPorCaixaId(int caixaid)
        {
            var listaCaixas = await (from caixas in _db.Caixas
                                     where caixas.Id == caixaid
                                     select new CaixaDto
                                     {
                                         Id = caixas.Id,
                                         DataAbertura = caixas.DataAbertura,
                                         DataEncerramento = caixas.DataEncerramento,
                                     }).ToListAsync();

            return listaCaixas;
        }


    }
}

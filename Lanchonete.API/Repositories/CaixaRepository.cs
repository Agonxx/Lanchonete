using Lanchonete.API.Database;
using Lanchonete.Shared.Dtos;
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

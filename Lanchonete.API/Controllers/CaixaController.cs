using Lanchonete.API.Repositories;
using Lanchonete.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lanchonete.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaixaController : ControllerBase
    {
        private readonly CaixaRepository _repo;

        public CaixaController(CaixaRepository repository)
        {
            _repo = repository;
        }

        [HttpGet(CaixaApi.BuscarCaixas)]
        public async Task<IActionResult> BuscarCaixas()
        {
            var obj = await _repo.BuscarCaixas();
            return Ok(obj);
        }

        [HttpGet(CaixaApi.BuscarCaixaAberto)]
        public async Task<IActionResult> BuscarCaixaAberto()
        {
            var obj = await _repo.BuscarCaixaAberto();
            return Ok(obj);
        }

        [HttpGet(CaixaApi.BuscarPorCaixaId)]
        public async Task<IActionResult> BuscarPorCaixaId([FromQuery] int caixaId)
        {
            var obj = await _repo.BuscarPorCaixaId(caixaId);
            return Ok(obj);
        }
    }
}

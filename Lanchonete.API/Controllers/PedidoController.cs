using Lanchonete.API.Repositories;
using Lanchonete.Shared.Dtos;
using Lanchonete.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lanchonete.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {

        private readonly PedidoRepository _repo;

        public PedidoController(PedidoRepository pedidoRepository)
        {
            _repo = pedidoRepository;
        }

        [HttpGet(PedidoApi.BuscarPedidos)]
        public async Task<IActionResult> BuscarPedidos()
        {
            var obj = await _repo.BuscarPedidos();
            return Ok(obj);
        }
        
        [HttpGet(PedidoApi.BuscarPorCaixaId)]
        public async Task<IActionResult> BuscarPorCaixaId([FromQuery] int caixaId)
        {
            var obj = await _repo.BuscarPorCaixaId(caixaId);
            return Ok(obj);
        }

        [HttpPost(PedidoApi.Registrar)]
        public async Task<IActionResult> Registrar([FromBody] PedidoDto pedidoObj)
        {
            var obj = await _repo.Registrar(pedidoObj);
            return Ok(obj);
        }
    }
}

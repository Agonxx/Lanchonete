using Lanchonete.API.Repositories;
using Lanchonete.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lanchonete.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
    }
}

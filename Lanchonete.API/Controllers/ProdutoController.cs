using Lanchonete.API.Repositories;
using Lanchonete.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lanchonete.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoRepository _repo;

        public ProdutoController(ProdutoRepository repository)
        {
            _repo = repository;
        }

        [HttpGet(ProdutoApi.BuscarProdutos)]
        public async Task<IActionResult> BuscarProdutos()
        {
            var obj = await _repo.BuscarProdutos();
            return Ok(obj);
        }

        [HttpGet(ProdutoApi.BuscarProdutoPorId)]
        public async Task<IActionResult> BuscarProdutoPorId([FromQuery] int produtoId)
        {
            var obj = await _repo.BuscarProdutoPorId(produtoId);
            return Ok(obj);
        }

    }
}

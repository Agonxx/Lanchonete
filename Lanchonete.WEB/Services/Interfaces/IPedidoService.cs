using Lanchonete.Shared.Dtos;

namespace Lanchonete.WEB.Services.Interfaces
{
    public interface IPedidoService
    {
        Task<List<PedidoDto>> BuscarPedidos();
        Task<PedidoDto> Registrar(PedidoDto produtoObj);
    }
}

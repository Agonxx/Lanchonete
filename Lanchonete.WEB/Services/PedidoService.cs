using Lanchonete.Shared.Dtos;
using Lanchonete.Shared.Models;
using Lanchonete.WEB.Services.Interfaces;
using Lanchonete.WEB.Utils;

namespace Lanchonete.WEB.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly HttpClientService _httpClientService;

        public PedidoService(HttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<List<PedidoDto>> BuscarPedidos()
        {
            var obj = await _httpClientService
                                    .GetAsync<List<PedidoDto>>($"Pedido/{PedidoApi.BuscarPedidos}");
            return obj.Dados;
        }

        public async Task<PedidoDto> Registrar(PedidoDto pedidoObj)
        {
            var obj = await _httpClientService
                                    .AddParamBody(nameof(pedidoObj), pedidoObj)
                                    .PostAsync<PedidoDto>($"Pedido/{PedidoApi.Registrar}");
            return obj.Dados;
        }


    }

}

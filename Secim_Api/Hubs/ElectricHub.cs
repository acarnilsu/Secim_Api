using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Secim_Api.Hubs
{
    public class ElectricHub:Hub
    {
        private readonly ElectricService _service;
        public ElectricHub(ElectricService service)
        {
            _service = service;
        }

        public async Task GetElectricConsumeList()
        {
            await Clients.All.SendAsync("ReceiveElectricList", _service.GetElectricChartsList());
        }
    }
}

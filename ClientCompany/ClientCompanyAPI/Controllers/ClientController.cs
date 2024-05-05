using ClientCompanyData.Entities;
using ClientCompanyDataAccess.Client;
using Microsoft.AspNetCore.Mvc;

namespace ClientCompanyController.Controller
{
    [ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _repository;
        public ClientController(IClientRepository repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetAllClient))]
        public async Task<IActionResult> GetAllClient()
        {
            var client = new Client { Name = "Hakkı", SurName = "Bulut", Email = "hakkibulut@gmail.com", PNumber = 1234567899, Sex = "E"};
            await _repository.Create(client);

            var firstClient = await _repository.GetClient();

            var model = _repository.GetAll().ToList();
            return (IActionResult)model;

        }
    }
}

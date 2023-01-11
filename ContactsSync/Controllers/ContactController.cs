using ContactsSync.Interface;
using ContactsSync.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace ContactsSync.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly RestClient _client;
        private IAllContracts _iAllContracts;

        public ContactController(IAllContracts iAllContracts)
        {
            _client = new RestClient("http://localhost:3000/");
            _iAllContracts = iAllContracts;
        }

        [HttpGet]
        public async Task<IActionResult> ReadData()
        {
            List<AllContractsVM> allContractsVMs = new List<AllContractsVM>();
            var request = new RestRequest("Contacts");

            var response = await _client.ExecuteGetAsync<Rootobject>(request);
            if (response.IsSuccessful)
            {
                try
                {
                    var data = response.Data;
                    await _iAllContracts.Save(data.Response.Data);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return Ok(response);
        }

    }


  

}

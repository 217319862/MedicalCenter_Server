using Microsoft.AspNetCore.Mvc;

namespace Server_MedicalCenter.Controllers
{
    [ApiController]
    [Route("api/contract")]
    public class ContractController : ControllerBase
    {

        [HttpGet]
        public bool Get()
        {
            return true;
        }

    }
}

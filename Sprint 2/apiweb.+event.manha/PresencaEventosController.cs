using apiweb._event.manha.Interface;
using apiweb._event.manha.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiweb._event.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresencaEventosController : ControllerBase
    {

        private readonly IPresencaEventoRepository _presecnasEventosRepository;

        public PresencaEventosController()
        {
            _presecnasEventosRepository = new PresencaEventoRepository();
        }
    }
}

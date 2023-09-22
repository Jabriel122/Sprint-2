using apiweb._event.manha.Domains;
using apiweb._event.manha.Interface;
using apiweb._event.manha.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiweb._event.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposEventoController : ControllerBase
    {

        private ITiposEventoRepository _tiposEventoRepository;

        public TiposEventoController()
        {
            _tiposEventoRepository = new TiposEventoRepository();
        }


        [HttpPost]
        //[Authorize(Roles = "administrador")]
        public IActionResult Post(TiposEvento tiposEvento)
        {
            try
            {
                _tiposEventoRepository.Cadastra(tiposEvento);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Authorize(Roles = "administrador")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _tiposEventoRepository.Deletar(id);
                return StatusCode(201);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

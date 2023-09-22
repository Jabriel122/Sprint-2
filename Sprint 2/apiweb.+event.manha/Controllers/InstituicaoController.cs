using apiweb._event.manha.Domains;
using apiweb._event.manha.Interface;
using apiweb._event.manha.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiweb._event.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class InstituicaoController : ControllerBase
    {

        private IInstituicaoRepository _instituicaoRepository;

        public InstituicaoController()
        {
            _instituicaoRepository = new InstituicaoRepository();
        }

        [HttpPost]
        public IActionResult Post(Instituicao instituicao)
        {
            try
            {
                _instituicaoRepository.Cadastrar(instituicao);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

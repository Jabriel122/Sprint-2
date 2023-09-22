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

    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]

        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]

        public IActionResult Get(Guid id)
        {
            try
            {
                return Ok(_usuarioRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get(string email, string senha)
        {
            try
            {
                return Ok(_usuarioRepository.BuscarPorEmailESenha(email, senha));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Authorize(Roles = "administrador")]
        public IActionResult Delete (Guid id)
        {
            try
            {
                _usuarioRepository.Deletar(id);
                return StatusCode(201); 

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }


    }
}

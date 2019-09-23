using ApiRest.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRest.Controllers
{
    [Route("rest/mars")]
    [ApiController]
    public class MarsController : ControllerBase
    {
        private readonly IRobo _robo;

        public MarsController(IRobo robo)
        {
            _robo = robo;
        }

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get()
        {
            return Ok("API Rest Robot. Acesse: (POST) http://localhost:8080/rest/mars/MML");
        }       

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPost("{value}")]
        public IActionResult Post(string value)
        {
            var resultado = _robo.Identificar(value.ToUpper());

            if (resultado.Sucesso)
                return Ok(string.Format("({0}, {1}, {2})", resultado.Robo.EixoX, resultado.Robo.EixoY, resultado.Robo.Face));
            else
                return BadRequest(resultado.Mensagem);
        }
    }
}
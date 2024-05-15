using ApiTesteDI.Container;
using Microsoft.AspNetCore.Mvc;

namespace ApiTesteDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuscarInfoControler : ControllerBase
    {
        private readonly IBuscarInfoId _buscarInfo;

        public BuscarInfoControler(IBuscarInfoId buscarInfoId)
        {
            _buscarInfo = buscarInfoId;
        }

        [HttpGet("BuscarInfo")]
        public IActionResult BuscarInfo(int id)
        {
            if (id <= 0)
            {
                return BadRequest("ID inválido!");
            }

            var retornarValor = _buscarInfo.BuscarInform(id);

            return Ok(retornarValor);
        }

    }
}

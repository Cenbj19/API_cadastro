using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CadastroClientess.Models;

namespace CadastroClientess.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpPost("Salvar")] // post estou enviando/postando o serviço para API
        public object Salvar([FromBody] Clientes clientes)
        {
            try
            {

            }
            catch (Exception ex)
            { 
            
            }

            return null;
        }
    }
}

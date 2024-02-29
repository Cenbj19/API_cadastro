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

        [HttpPost("Alterar")] // post estou enviando/postando o serviço para API
        public object Alterar([FromBody] Clientes clientes)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }

            return null;
        }

        [HttpGet("Listar")] //Buscando informações do banco de dados 
        public object Listar() //não tem parâmetro, vai devolver um objeto 
        {
            try
            {

            }
            catch (Exception ex)
            {

            }

            return null;
        }

        [HttpDelete("Deletar")]
        public object Deletar(int IdCliente)
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

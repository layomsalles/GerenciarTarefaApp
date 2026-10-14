using GerenciarTarefaApp.Application.Dtos.Request;
using GerenciarTarefaApp.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarTarefaApp.Api.Controllers
{
    [Route("api/tarefa")]
    [ApiController]
    public class TarefaController(ITarefaService _tarefaService) : ControllerBase
    {
        [HttpPost]
        public IActionResult CriarTarefa([FromBody] TarefaRequest tarefaRequest)
        {
            try
            {
                var request = new TarefaRequest
                (
                    tarefaRequest.Titulo,
                    tarefaRequest.Descricao
                );

                var response = _tarefaService.CriarTarefa(request);

                return StatusCode(201, response);
            } catch (ApplicationException ex)
            {
                return StatusCode(400, new { message = ex.Message });
            } catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarTarefa()
        {
            try
            {
                var respose = _tarefaService.ListarTarefa();
                return StatusCode(200, respose);
            } catch(ApplicationException ex)
            {
                return StatusCode(400, new { message = ex.Message });
            } catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public IActionResult ObterTarefaId(Guid id)
        {
            try
            {
                var response = _tarefaService.ObterTarefaPorId(id);
                return StatusCode(200, response);
            } catch(ApplicationException ex)
            {
                return StatusCode(400, new { message = ex.Message });
            } catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

        [HttpPatch("{id}/Atualizar")]
        public IActionResult AtualizarTarefa(Guid id, [FromBody] TarefaUpdateRequest request)
        {
            try
            {
                var resposne = _tarefaService.AtualizarTarefa(id, request);

                return StatusCode(200, resposne);
            } catch(ApplicationException ex)
            {
                return StatusCode(400, new { message = ex.Message });
            } catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarTarefa(Guid id)
        {
            try
            {
                var response = _tarefaService.DeletarTarefa(id);
                return StatusCode(200, response);
            } catch(ApplicationException ex)
            {
                return StatusCode(400, new { message = ex.Message });
            } catch(Exception ex)
            {
                return StatusCode(400, new { message = ex.Message });
            }
        }
    }
}

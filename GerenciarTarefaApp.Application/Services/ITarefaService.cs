using GerenciarTarefaApp.Application.Dtos.Request;
using GerenciarTarefaApp.Application.Dtos.Response;

namespace GerenciarTarefaApp.Application.Services
{
    public interface ITarefaService
    {
        TarefaResponse CriarTarefa(TarefaRequest request);
        TarefaResponse AtualizarTarefa(Guid id, TarefaUpdateRequest request);
        List<TarefaResponse> ListarTarefa();
        TarefaResponse ObterTarefaPorId(Guid id);
        TarefaResponse DeletarTarefa(Guid id);
    }
}

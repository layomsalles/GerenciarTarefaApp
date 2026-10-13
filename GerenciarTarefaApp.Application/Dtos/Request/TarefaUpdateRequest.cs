using GerenciarTarefaApp.Domain.Enum;

namespace GerenciarTarefaApp.Application.Dtos.Request
{
    public record TarefaUpdateRequest(
        string? Titulo,
        string? Descricao,
        TarefaEnum? Status
        );
}

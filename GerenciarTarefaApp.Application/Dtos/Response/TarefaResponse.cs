using GerenciarTarefaApp.Domain.Enum;

namespace GerenciarTarefaApp.Application.Dtos.Response
{
    public record TarefaResponse(
        Guid Id,
        string Titulo,
        string Descricao,
        DateTime DataCriacao,
        DateTime? DataConclusao,
        TarefaEnum Status
        );
}

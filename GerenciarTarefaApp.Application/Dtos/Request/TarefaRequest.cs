using System.ComponentModel.DataAnnotations;

namespace GerenciarTarefaApp.Application.Dtos.Request
{
    public record TarefaRequest(
        [Required(ErrorMessage = "O Título é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O Título deve ter no máximo 100 caracteres")]
        string Titulo,

        string Descricao
        );
}
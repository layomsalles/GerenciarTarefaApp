using GerenciarTarefaApp.Domain.Enum;

namespace GerenciarTarefaApp.Domain.Entities
{
    public class Tarefa
    {
        public Guid Id { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime? DataConclusao { get; private set; }
        public TarefaEnum Status { get; private set; }

        public void CriarTarefa(string titulo, string descricao) 
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = DateTime.Now;
        }

        public void AtualizarTarefa(string? titulo = null, string? descricao = null, TarefaEnum? status = null) 
        {
            if (!string.IsNullOrWhiteSpace(titulo))
            {
                Titulo = titulo;
            }

            if (!string.IsNullOrWhiteSpace(descricao))
            {
                Descricao = descricao;
            }

            if(status.HasValue)
            {
                Status = status.Value;

                if(status.Value == TarefaEnum.Concluida)
                {
                    DataConclusao = DateTime.Now;
                }
            }

        }
    }
}

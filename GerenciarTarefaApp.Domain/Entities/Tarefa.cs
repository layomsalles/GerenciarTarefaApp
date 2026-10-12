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

        public void CriarTarefa(Guid id, string titulo, string descricao, DateTime dataCriacao, DateTime? dataConclusao, TarefaEnum status) 
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = dataCriacao;
            DataConclusao = dataConclusao;
            Status = status;
        }

        public void AtualizarTarefa(string titulo, string descricao, DateTime dataCriacao, DateTime? dataConclusao, TarefaEnum status) 
        {
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = dataCriacao;
            DataConclusao = dataConclusao;
            Status = status;
        }

        public void AtualizarStatus(TarefaEnum status)
        {
            Status = status;
        }
    }
}

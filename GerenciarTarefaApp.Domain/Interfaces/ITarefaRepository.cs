using GerenciarTarefaApp.Domain.Entities;

namespace GerenciarTarefaApp.Domain.Interfaces
{
    public interface ITarefaRepository
    {
        void CriarTarefa(Tarefa tarefa);
        Tarefa? ListarTarefaPorId(Guid id);
        List<Tarefa> ListarTarefa();
        void AtualizarTarefa(Tarefa tarefa);
        void DeletarTarefa(Guid id);
    }
}

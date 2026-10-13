using GerenciarTarefaApp.Domain.Entities;
using GerenciarTarefaApp.Domain.Interfaces;
using GerenciarTarefaApp.Infra.Data.Contexts;

namespace GerenciarTarefaApp.Infra.Data.Repositories
{
    public class TarefaRepository(DataContext dataContext) : ITarefaRepository
    {
        void ITarefaRepository.AtualizarTarefa(Tarefa tarefa)
        {
            dataContext.Set<Tarefa>().Update(tarefa);
            dataContext.SaveChanges();
        }

        void ITarefaRepository.CriarTarefa(Tarefa tarefa)
        {
            dataContext.Set<Tarefa>().Add(tarefa);
            dataContext.SaveChanges();
        }

        void ITarefaRepository.DeletarTarefa(Guid id)
        {
            var tarefa = dataContext.Set<Tarefa>().Find(id);
            if(tarefa != null)
            {
                dataContext.Set<Tarefa>().Remove(tarefa);
                dataContext.SaveChanges();
            }
        }

        List<Tarefa> ITarefaRepository.ListarTarefa()
        {
            return dataContext.Set<Tarefa>().ToList();
        }

        Tarefa? ITarefaRepository.ListarTarefaPorId(Guid id)
        {
            return dataContext.Set<Tarefa>().FirstOrDefault(t => t.Id == id);
        }
    }
}

using GerenciarTarefaApp.Application.Dtos.Request;
using GerenciarTarefaApp.Application.Dtos.Response;
using GerenciarTarefaApp.Application.Interfaces;
using GerenciarTarefaApp.Domain.Entities;
using GerenciarTarefaApp.Domain.Interfaces;

namespace GerenciarTarefaApp.Application.Services
{
    public class TarefaService(ITarefaRepository _tarefaRepository) : ITarefaService
    {
        public TarefaResponse AtualizarTarefa(Guid id, TarefaUpdateRequest request)
        {
            var tarefaExiste = _tarefaRepository.ListarTarefaPorId(id);

            if(tarefaExiste == null)
            {
                throw new ApplicationException("Tarefa não encontrada");
            }

            tarefaExiste.AtualizarTarefa(request.Titulo, request.Descricao, request.Status);

            _tarefaRepository.AtualizarTarefa(tarefaExiste);

            return new TarefaResponse
            (
                tarefaExiste.Id,
                tarefaExiste.Titulo,
                tarefaExiste.Descricao,
                tarefaExiste.DataCriacao,
                tarefaExiste.DataConclusao,
                tarefaExiste.Status
            );
        }

        public TarefaResponse CriarTarefa(TarefaRequest request)
        {
            var tarefa = new Tarefa();

            tarefa.CriarTarefa(request.Titulo, request.Descricao);

            _tarefaRepository.CriarTarefa(tarefa);

            return new TarefaResponse
            (
                tarefa.Id,
                tarefa.Titulo,
                tarefa.Descricao,
                tarefa.DataCriacao,
                tarefa.DataConclusao,
                tarefa.Status
            );
        }

        public TarefaResponse DeletarTarefa(Guid id)
        {
            var tarefa = _tarefaRepository.ListarTarefaPorId(id);

            if (tarefa == null)
            {
                throw new ApplicationException("Tarefa não encontrada");
            }

            _tarefaRepository.DeletarTarefa(id);

            return new TarefaResponse
            (
                tarefa.Id,
                tarefa.Titulo,
                tarefa.Descricao,
                tarefa.DataCriacao,
                tarefa.DataConclusao,
                tarefa.Status
            );
        }

        public List<TarefaResponse> ListarTarefa()
        {
            var tarefas = _tarefaRepository.ListarTarefa();

            return tarefas.Select(tarefa => new TarefaResponse
            (
                tarefa.Id,
                tarefa.Titulo,
                tarefa.Descricao,
                tarefa.DataCriacao,
                tarefa.DataConclusao,
                tarefa.Status
            )).ToList();
        }

        public TarefaResponse ObterTarefaPorId(Guid id)
        {
            var tarefa = _tarefaRepository.ListarTarefaPorId(id);

            if(tarefa == null)
            {
                throw new ApplicationException("Tarefa não encontrada");
            }

            return new TarefaResponse
            (
                tarefa.Id,
                tarefa.Titulo,
                tarefa.Descricao,
                tarefa.DataCriacao,
                tarefa.DataConclusao,
                tarefa.Status
            );
        }
    }
}

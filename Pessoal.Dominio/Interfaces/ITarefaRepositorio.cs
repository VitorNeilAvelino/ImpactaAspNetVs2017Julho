using System.Collections.Generic;

namespace Pessoal.Dominio.Interfaces
{
    public interface ITarefaRepositorio
    {
        int Inserir(Tarefa tarefa);
        List<Tarefa> Selecionar();
        Tarefa Selecionar(int id);
        void Atualizar(Tarefa tarefa);
        void Excluir(int id);
    }
}
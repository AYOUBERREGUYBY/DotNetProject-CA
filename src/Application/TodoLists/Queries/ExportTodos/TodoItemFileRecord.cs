using REpo_gIt.Application.Common.Mappings;
using REpo_gIt.Domain.Entities;

namespace REpo_gIt.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}

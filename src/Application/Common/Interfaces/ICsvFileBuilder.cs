using REpo_gIt.Application.TodoLists.Queries.ExportTodos;

namespace REpo_gIt.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}

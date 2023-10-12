using System.Globalization;
using REpo_gIt.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace REpo_gIt.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}

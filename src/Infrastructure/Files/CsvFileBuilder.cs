using System.Globalization;
using REpo_gIt.Application.Common.Interfaces;
using REpo_gIt.Application.TodoLists.Queries.ExportTodos;
using REpo_gIt.Infrastructure.Files.Maps;
using CsvHelper;

namespace REpo_gIt.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}

using REpo_gIt.Application.Common.Mappings;
using REpo_gIt.Domain.Entities;

namespace REpo_gIt.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; init; }

    public string? Title { get; init; }
}

using REpo_gIt.Application.Common.Exceptions;
using REpo_gIt.Application.TodoLists.Commands.CreateTodoList;
using REpo_gIt.Application.TodoLists.Commands.DeleteTodoList;
using REpo_gIt.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace REpo_gIt.Application.IntegrationTests.TodoLists.Commands;

using static Testing;

public class DeleteTodoListTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand(99);
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand(listId));

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}

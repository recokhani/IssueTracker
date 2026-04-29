using IssueTracker.Domain.Common;
using IssueTracker.Domain.ValueObjects;

namespace IssueTracker.Domain.Entities;

public class TodoList : BaseAuditableEntity
{
    public string?  Title { get; set; }
    public Color? Color { get; set; } = Color.Grey;
    public IList<TodoItem>? Items { get; private set; } =  new List<TodoItem>();
}
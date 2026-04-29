using IssueTracker.Domain.Common;
using IssueTracker.Domain.Entities;

namespace IssueTracker.Domain.Events;

public class TodoItemCompletedEvent : BaseEvent
{
    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }
    public TodoItem Item { get; }
}
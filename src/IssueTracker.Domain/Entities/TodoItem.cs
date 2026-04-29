using IssueTracker.Domain.Common;
using IssueTracker.Domain.Enums;
using IssueTracker.Domain.Events;

namespace IssueTracker.Domain.Entities;

public class TodoItem : BaseAuditableEntity
{
    public int ListId { get; set; }
    public string Title { get; set; }
    public string? Note { get; set; }
    
    
    public PriorityLevel Priority { get; set; }

    private bool _done;

    public bool Done
    {
        get => _done;
        set
        {
            if (value && !_done)
            {
                AddDomainEvent(new TodoItemCompletedEvent(this));
            }
            _done = value;
        }
    }



    public TodoList? List { get; set; } = null;


}
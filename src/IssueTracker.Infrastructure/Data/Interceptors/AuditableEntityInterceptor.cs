using IssueTracker.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace IssueTracker.Infrastructure.Interceptors;

public class AuditableEntityInterceptor : SaveChangesInterceptor
{
    private readonly IUser _user;
    private readonly TimeProvider _timeProvider;
    
    public AuditableEntityInterceptor(IUser user, TimeProvider timeProvider)
    {
        _user = user;
        _timeProvider = timeProvider;
    }

    /*public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
    }*/
    
    
    
}
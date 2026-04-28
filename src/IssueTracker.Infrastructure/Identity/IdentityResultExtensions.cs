using IssueTracker.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace IssueTracker.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToIdentityResult(this IdentityResult result)
    {
        return  result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
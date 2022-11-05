namespace Blazr.Tools.Models
{
    internal record Result(bool Succeeded, string? Error = null) : IResult;
}

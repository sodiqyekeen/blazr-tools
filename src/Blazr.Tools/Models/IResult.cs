namespace Blazr.Tools.Models
{
    public interface IResult
    {
        public bool Succeeded { get; }
        public string? Error { get; }
    }
}

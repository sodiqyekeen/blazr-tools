using Blazr.Tools.Models;

namespace Blazr.Tools.Services
{
    public interface IClipboardService:IAsyncDisposable
    {
        Task<IResult> CopyText(string text);
    }
}

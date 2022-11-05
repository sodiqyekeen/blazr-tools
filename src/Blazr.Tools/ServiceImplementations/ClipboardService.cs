using Blazr.Tools.Models;
using Blazr.Tools.Services;
using Microsoft.JSInterop;

namespace Blazr.Tools.ServiceImplementations
{
    internal class ClipboardService : IClipboardService
    {
        private readonly Lazy<Task<IJSObjectReference>> _clipboardJs;
        public ClipboardService(IJSRuntime jsRuntime)
        {
            _clipboardJs = new Lazy<Task<IJSObjectReference>>(() => jsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/Blazr.Tools/js/blazrtools.min.js").AsTask());
        }
        public async Task<IResult> CopyText(string text)
        {
            var clipboarHandler = await _clipboardJs.Value;
            var result = await clipboarHandler.InvokeAsync<Result>("copyText", text);
            return new Result(result.Succeeded, result.Error);
        }

        public async ValueTask DisposeAsync()
        {
            if (_clipboardJs.IsValueCreated)
            {
                var clipboarHandler = await _clipboardJs.Value;
                await clipboarHandler.DisposeAsync();
            }
        }
    }
}

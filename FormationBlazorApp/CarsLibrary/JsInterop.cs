using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibrary
{
    internal class JsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> module;


        public JsInterop(IJSRuntime jsRuntime)
        {
            module = new(() => jsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/CarsLibrary/CarsLibrary.js").AsTask());
        }

        public async Task GoBackAsync()
        {
            var moduleInt = await module.Value;
            await moduleInt.InvokeVoidAsync("goBack");
        }

        public async ValueTask<int> Add(int a, int b)
        {
            var moduleInt = await module.Value;
            return await moduleInt.InvokeAsync<int>("goBack", a, b);
        }

        public async ValueTask DisposeAsync()
        {
            if (module.IsValueCreated)
            {
                var moduleInt = await module.Value;
                await moduleInt.DisposeAsync();
            }
        }
    }
}

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Microsoft.JSInterop.Implementation;

namespace PetBlazor.Components
{
    public class JsExplorerModel : ComponentBase
    {
        [Inject]
        IJSRuntime JS { get; set; }

        private Lazy<IJSObjectReference> jsModule { get; set; }

        async protected override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                jsModule = new(await JS.InvokeAsync<IJSObjectReference>("import", "./Components/JsExplorerComponent.razor.js"));
            }
        }
        public async ValueTask DisposeAsync()
        {
            if (jsModule.IsValueCreated)
            {
                await jsModule.Value.DisposeAsync();
            }
        }
    }
}

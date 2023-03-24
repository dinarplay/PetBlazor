using Microsoft.AspNetCore.Components;

namespace PetBlazor.Components
{
    public class LoadingModel : ComponentBase
    {
        public List<string> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            Employees = new List<string> { "123" };
        }
    }
}

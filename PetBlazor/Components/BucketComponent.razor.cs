using Microsoft.AspNetCore.Components;
using PetBlazor.Models;
using PetBlazor.Services;

namespace PetBlazor.Components
{
    public class BucketModel : ComponentBase
    {
        [Inject]
        private DbManagerService dbManagerService { get; set; }

        public List<Bucket> buckets { get; set; }
        async protected override Task OnInitializedAsync()
        {
            buckets = await dbManagerService.GetAllBuckets();
        }
    }    
}
    
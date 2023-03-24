using Microsoft.AspNetCore.Components;
using PetBlazor.Services;
using System;

namespace PetBlazor.Components
{
    public class AgeCalculateModel : ComponentBase
    {
        [Inject]
        AgeCalculateService ageService { get; set; }
        public string ageResult { get; set; }
        [Parameter]
        public DateOnly dateOnly { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        public void GetAge()
        {
            ageResult = ageService.GetAge(dateOnly);
        }
    }
}

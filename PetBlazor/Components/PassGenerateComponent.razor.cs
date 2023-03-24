using Microsoft.AspNetCore.Components;
using PetBlazor.Services;

namespace PetBlazor.Components
{
    public class PassGenerateModel : ComponentBase 
    {
        [Inject]
        PassGenerateService passService { get; set; }
        public string passResult { get; set; }
        public int passCount { get; set; } = 16;
        public bool isCaps { get; set; } = true;
        public bool isNumbers { get; set; } = true;
        public bool isSymbols { get; set; } = true;
        public void GetPass()
        {
            passResult = passService.GeneratePassword(passCount, isCaps, isNumbers, isSymbols);
        }
    }
}

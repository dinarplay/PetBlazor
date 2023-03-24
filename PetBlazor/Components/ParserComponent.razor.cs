using Microsoft.AspNetCore.Components;
using PetBlazor.Services;

namespace PetBlazor.Components
{
    public class ParserModel : ComponentBase
    {
        [Inject]
        ParseService parseService { get; set; }
        public string result { get; set; }
        public string url { get; set; }
        async public Task Parse()
        {
            await parseService.ParseTitle(url);
            result = parseService.tempResult;
        }
    }
}

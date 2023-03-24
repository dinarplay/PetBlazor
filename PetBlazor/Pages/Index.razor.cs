using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using Microsoft.AspNetCore.Components;
using PetBlazor.Services;
using System;

namespace PetBlazor.Pages
{
    public class IndexModel : ComponentBase
    {
        [Inject]
        ParseService parseService { get; set; }
        public string result{ get; set; }
        public string url { get; set; }
        async public Task Parse()
        {
            await parseService.ParseTitle(url);
            result = parseService.tempResult;
        }
    }
}

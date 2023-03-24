using AngleSharp;
using AngleSharp.Dom;

namespace PetBlazor.Services
{
    public class ParseService
    {
        public string tempResult;
        async public Task ParseTitle(string tempUrl)
        {
            string url = tempUrl is null ? "https://dtf.ru/u/389606-languid-basil/890200-pust-za-nas-vse-delayut-boty-parsing-saytov-na-c-i-anglesharp" : tempUrl;
            var config = Configuration.Default.WithDefaultLoader();
            using var context = BrowsingContext.New(config);
            using var doc = await context.OpenAsync(url);
            tempResult = doc.Title;
        }
        async public Task ParseTe(string tempUrl)
        {
            string url = tempUrl is null ? "https://dtf.ru/u/389606-languid-basil/890200-pust-za-nas-vse-delayut-boty-parsing-saytov-na-c-i-anglesharp" : tempUrl;
            var config = Configuration.Default.WithDefaultLoader();
            using var context = BrowsingContext.New(config);
            using var doc = await context.OpenAsync(url);
            tempResult = doc.Title;
        }
    }
}

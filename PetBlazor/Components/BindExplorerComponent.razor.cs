using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PetBlazor.Components
{
    public class BindExplorerModel : ComponentBase
    {
        public bool bl1;
        public bool bl2;
        public bool bl3;

        public int someValue { get; set; }
        public int anotherValue { get; set; }
        public string Message { get; set; }
        public string coordinations { get; set; } = "Nothing";
        public double text { get; set; }

        [Parameter]
        public EventCallback LinkEventCallback { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> LinkEventCallbackWithT { get; set; }

        [Parameter]
        public EventCallback<string> LinkEventCallbackWithArbitraty { get; set; }
        public string data = "click";

        public void CalcCoords(MouseEventArgs e)
        {
            coordinations = $"{e.ClientX}, {e.ScreenX}, {e.OffsetX}, {e.PageX} / {e.ClientY}, {e.ScreenY}, {e.OffsetY}, {e.PageY}";
        }
        public void Click(double db)
        {
            text = db;
        }

        public string SomeText;
        public void SomeFunc()
        {
            SomeText = "!/ someFunc is pressed";
        }
    }
}

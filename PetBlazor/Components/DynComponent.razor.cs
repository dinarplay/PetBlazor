using Microsoft.AspNetCore.Components;
using PetBlazor.Models;

namespace PetBlazor.Components
{
    public class DynModel : ComponentBase
    {
        public Widget widget { get; set; }
        public DynModel()
        {
            widget = new Widget();
        }        
    }
}

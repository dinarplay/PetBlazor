using Microsoft.AspNetCore.Components;
using System.Security.Claims;

namespace PetBlazor.Shared
{
    public class HeaderModel : ComponentBase
    {
        public bool isAuth
        {
            get
            {
                if (ClaimsPrincipal.Current is not null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string Name
        {
            get
            {
                return ClaimsPrincipal.Current.FindFirst("Name").Value[0].ToString().ToUpper();
            }
        }
    }
}

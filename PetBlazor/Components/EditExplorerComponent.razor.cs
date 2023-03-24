using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using PetBlazor.Models;
using System;

namespace PetBlazor.Components
{
    public class EditExplorerModel : ComponentBase
    {
        public User user { get; set; }
        public EditContext editContext { get; set; }
        public bool isFormValid { get; set; }
        protected override async Task OnInitializedAsync()
        {
            user = new User()
            {
                Id = 1,
                Name = "Tester",
                Password = "111"
            };
            editContext = new EditContext(user);
            editContext.OnFieldChanged += (x, y) =>
            {
                isFormValid = !editContext.Validate();
            };
        }
        public void ValSubmit()
        {
            user.Name = "Tester testing";
        }
        public void InvalSubmit()
        {
            user.Name = "Tester not testing";
        }
        public void Submit()
        {
            if (editContext.Validate())
            {
                user.Name = "Tes";
            }
            else
            {
                user.Name = "Tes123";
            }
        }
    }
}

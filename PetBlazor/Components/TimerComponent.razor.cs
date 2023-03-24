using Microsoft.AspNetCore.Components;
using System.Timers;

namespace PetBlazor.Components
{
    public class TimerModel : ComponentBase
    {
        private System.Timers.Timer myTimer { get; set; }
        public int currentMin { get; set; } = 0;
        public int currentSec { get; set; } = 0;
        public bool state { get; set; }
        async protected override void OnInitialized()
        {
            myTimer = new System.Timers.Timer();
            myTimer.Interval = 1000;
            myTimer.Elapsed += IncrementSecond;
            state = myTimer.Enabled;
        }
        protected void IncrementSecond(object source, ElapsedEventArgs e)
        {
            currentSec++;
            if (currentSec == 60)
            {
                currentSec = 0;
                currentMin++;
            }
            InvokeAsync(StateHasChanged);
        }
        public void StartTimer()
        {
            currentMin = 0;
            currentSec = 0; 
            myTimer.Start();
            state = false;
        }
        public void PauseTimer()
        {
            if (state)
            {
                myTimer.Enabled = state;
                state = !state;
            }
            else
            {
                myTimer.Enabled = state;            
                state = !state;
            }
        }
    }
}

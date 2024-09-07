using Microsoft.AspNetCore.Components;

namespace BlazorDataBind.Components
{
    public partial class BmiCalc
    {
        private double Height { get; set; } = 160;
        private double Weight { get; set; } = 60;

        [Parameter]
        public EventCallback<double> OnResultChaned { get; set; }

        private async void clickCalc()
        {
            var result = Weight / ((Height / 100) * (Height / 100));
            await OnResultChaned.InvokeAsync(result);
        }
    }
}

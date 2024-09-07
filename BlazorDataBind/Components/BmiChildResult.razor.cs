using Microsoft.AspNetCore.Components;

namespace BlazorDataBind.Components
{
    public partial class BmiChildResult
    {
        private double Height { get; set; } = 160;

        [Parameter]
        public double Weight { get; set; } = 70;

        [Parameter]
        public double Result { get; set; }

        [Parameter]
        public EventCallback<double> WeightChanged { get; set; }

        [Parameter]
        public EventCallback<double> ResultChanged { get; set; }

        public async void clickCalc()
        {
            Result = Weight / ((Height / 100) * (Height / 100));
            await ResultChanged.InvokeAsync(Result);
        }
    }
}

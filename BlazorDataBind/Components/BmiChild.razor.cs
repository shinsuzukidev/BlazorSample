using Microsoft.AspNetCore.Components;

namespace BlazorDataBind.Components
{
    public partial class BmiChild
    {
        // パラメータの変更を受け付ける時に必須,
        // イベント名: プロパティ名 + "Changed"
        [Parameter]
        public EventCallback<double> WeightChanged { get; set; }

        private double Height { get; set; } = 160;
        private double _weight { get; set; } = 70;
        private double Result { get; set; }

        [Parameter]
        public double Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                Result = Weight / (Height / 100 * (Height / 100));
            }
        }
    }
}

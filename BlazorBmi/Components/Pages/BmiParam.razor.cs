using Microsoft.AspNetCore.Components;

namespace BlazorBmi.Components.Pages
{
    public partial class BmiParam
    {
        // クエリーから受け取る場合は常に文字列
        [Parameter]
        public string? Height { get; set; }  

        [Parameter]
        public string? Weight { get; set; }

        private BmiItem? bmi;
        public string fontSize { get; set; } = "32px";

        protected override void OnInitialized()
        {
            if (!string.IsNullOrEmpty(Height)) 
            {
                bmi = new BmiItem()
                {
                    Name = "匿名",
                    Height = double.Parse(Height),
                    Weight = double.Parse(Weight!),
                };
            } 
            else
            {
                bmi = new BmiItem();
            }
        }
    }
}

using Microsoft.AspNetCore.Components;

namespace BlazorBmi.Components.Pages
{
    public partial class BmiChildAttr
    {
        // 属性スプラッティング

        [Parameter]
        public string? Name { get; set; }

        [Parameter]
        public double Height{ get; set; }

        [Parameter]
        public double Weight { get; set; }

        private BmiItem? item;

        protected override void OnInitialized()
        {
            item = new BmiItem()
            {
                Name = Name!,
                Height = Height,
                Weight = Weight,
            };
        }

        [Parameter]
        public RenderFragment? ChildContent { get; set; } 
    }
}

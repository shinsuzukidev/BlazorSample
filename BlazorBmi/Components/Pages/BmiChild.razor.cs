using Microsoft.AspNetCore.Components;

namespace BlazorBmi.Components.Pages
{
    public partial class BmiChild
    {
        [Parameter]
        public BmiItem? Item { get; set; }

        // リストを受け取るときにChildContentを固定で書く
        [Parameter]
        public RenderFragment? ChildContent { get; set; }    
    }
}

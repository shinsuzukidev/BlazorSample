using BlazorDataBind.Components;

namespace BlazorDataBind.Components.Pages
{
    public partial class ChildClick
    {
        public double Bmi {  get; set; }
        public void OnResultChaned(double result) 
        {
            this.Bmi = result;
        }
    }
}

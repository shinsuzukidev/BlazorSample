namespace BlazorBmi.Components.Pages
{
    public partial class BmiList
    {
        public List<BmiItem> bmiList { get; set; }  = new();

        protected override void OnInitialized()
        {
            bmiList = new List<BmiItem>();
            bmiList.Add(new BmiItem());
            bmiList.Add(new BmiItem());
            bmiList.Add(new BmiItem());
            bmiList.Add(new BmiItem());
        }
    }
}

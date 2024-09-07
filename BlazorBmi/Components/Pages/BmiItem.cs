namespace BlazorBmi.Components.Pages
{
    public class BmiItem
    {
        public string Name { get; set; } = "名無し";
        public double Height { get; set; } = 100;
        public double Weight { get; set; } = 100;
        public double Bmi {
            get => Weight / ((Height / 100) * (Height / 100));
        }
        
        public string fontSize = "32px";
    }
}

namespace BlazorHello.Components.Pages;

public partial class Counter
{
    private int currentCount = 0;
    private DateTime now = DateTime.Now;

    private void IncrementCount()
    {
        currentCount++;
    }

    private void UpdateTime()
    {
        now = DateTime.Now;
    }
}
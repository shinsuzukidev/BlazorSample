using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BlazorForm.Components.Pages
{
    public partial class BlazorInput
    {
        private Address addressModel = new();
        public string? Message { get; set; }

        public void onValidSubmit()
        {
            Message = $"thanks {addressModel.name}.";
        }

        private List<string> prefectureList = new List<string>()
        {
            "北海道",
            "東京",
            "沖縄"
        };
    }
}

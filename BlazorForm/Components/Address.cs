
using System.ComponentModel.DataAnnotations;

namespace BlazorForm.Components
{
    public class Address
    {
        [StringLength(7, ErrorMessage ="郵便番号は7桁です")]
        public string zipCode {  get; set; }    
        public string prefecture { get; set; }
        [Required(ErrorMessage="電話番号は必須です")]
        public string telephone { get; set; }
        [Required(ErrorMessage = "名前を入力してください")]
        public string name { get; set; }
        [Range(10, 100, ErrorMessage ="年齢は10～100才までです")]
        public int age { get; set; }
        public bool isVisitDate { get; set; }
        public DateTime? visitDate { get; set; }    

    }
}

using System.ComponentModel.DataAnnotations;

namespace WebMvc1.Models
{
    public class FormModel
    {
        [Display(Name = "Nazwa elementu")]
        public string Name { get; set; }
        [Display(Name = "Data urodzenia")]
        public string Data { get; set; }
        [Display(Name = "Ilość dni od urodzenia")]
        public string Days { get; set; }
    }
}

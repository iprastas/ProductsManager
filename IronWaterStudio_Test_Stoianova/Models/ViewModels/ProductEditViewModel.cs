using System.ComponentModel.DataAnnotations;

namespace IronWaterStudio_Test_Stoianova.Models.ViewModels
{
    public class ProductEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название обязательно для ввода.")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        [Required(ErrorMessage = "Цена обязательна для заполнения.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Цена должна быть выше нуля.")]
        public decimal Price { get; set; }
    }
}

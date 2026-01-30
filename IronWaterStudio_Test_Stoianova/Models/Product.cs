using System.ComponentModel.DataAnnotations;

namespace IronWaterStudio_Test_Stoianova.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Название обязательно для ввода.")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Цена должна быть выше нуля и с точностью два знака после запятой.")]
        public decimal Price { get; set; }

    }
}

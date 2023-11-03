using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormsApp.Models
{
    
    public class Product 
    {
        [Display(Name ="Urun Id")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Gerekli bir alan")]
        [StringLength(150)]
        [Display(Name ="Urun Adı")]
        public string Name { get; set; } = null!;
        [Required]
        [Range(0, 100000)]
        [Display(Name ="Fiyat")]
        public decimal? Price { get; set; }
        [Display(Name ="Resim")]
        public string? Image { get; set; }
        [Display(Name = "Aktiflik")]
        public bool IsActive { get; set; }

        [Required]
        [Display(Name ="Category")]
        public int? CategoryId { get; set; }

    }

}
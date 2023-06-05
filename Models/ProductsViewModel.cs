using Microsoft.AspNetCore.Http;
using SuperShopBrunoFerreira.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace SuperShopBrunoFerreira.Models
{
    public class ProductsViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}

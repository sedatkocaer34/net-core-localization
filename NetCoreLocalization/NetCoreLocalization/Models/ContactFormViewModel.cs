using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreLocalization.Models
{
    [BindProperties]
    public class ContactFormViewModel 
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "{0} gereklidir.")]
        public string AdSoyad { get; set; }

        [Display(Name = "Mesaj")]
        [Required(ErrorMessage = "{0} gereklidir.")]
        public string Mesaj { get; set; }
    }
}

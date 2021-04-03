using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Personel
    {
        public int Id { get; set; }
        [Display(Name="Adı Soyadı")]
        [Required]
        [StringLength(60, MinimumLength =3, ErrorMessage ="{0} bilgisi minimum {2} maksimum {1} uzunluğunda olmalıdır")]
        
        public string Adsoyad { get; set; }

        [Display(Name ="Doğum Tarihi")]
        [Range(typeof(DateTime),"1900-01-01", "2013-01-01") ]
            
        public DateTime Dogum { get; set; }
    }
}

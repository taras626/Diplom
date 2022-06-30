using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TsukanovaDesign.Domain.Entites
{
    public class HelperAdvice
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Текст совета")]
        public string TextAdvice { get; set; }
    }
}

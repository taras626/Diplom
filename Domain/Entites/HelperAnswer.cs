using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TsukanovaDesign.Domain.Entites
{
    public class HelperAnswer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Текст ответа")]
        public string TextAnswer { get; set; }

        public int HelperAdviceId { get; set; }
        [Required]
        [Display(Name = "Id совета")]
        public HelperAdvice HelperAdvice { get; set; }
    }
}

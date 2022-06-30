using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TsukanovaDesign.Domain.Entites
{
    public class Feedback
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "ФИО")]
        public string Name { get; set; }

        [Display(Name = "Текст отзыва")]
        public string Text { get; set; }

        [Required]
        [Display(Name = "Оценка")]
        public int Count { get; set; }
    }
}

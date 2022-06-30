using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TsukanovaDesign.Domain.Entites
{
    public class ObjectOfPortfolio
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Наименование объекта")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Площадь")]
        public decimal Square { get; set; }

        [Required]
        [Display(Name = "Дата проекта")]
        public DateTime DateOfWorkOnProject { get; set; }


        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Кол-во картинок")]
        public int CountOfPics { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TsukanovaDesign.Domain.Entites
{
    public class Price
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название тарифа")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Цена")]
        public int PriceCount { get; set; }

        [Required]
        [Display(Name = "Описание тарифа")]
        public string Description { get; set; }
    }
}

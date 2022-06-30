using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TsukanovaDesign.Domain.Entites
{
    public class QuestionAnswersConnector
    {
        public int HelperQuestionId { get; set; }
        [Required]
        public HelperQuestion HelperQuestion { get; set; }

        public int HelperAnswerId { get; set; }
        [Required]
        [Key]
        public HelperAnswer HelperAnswer { get; set; }
    }
}

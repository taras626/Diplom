using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain;
using TsukanovaDesign.Domain.Entites;

namespace TsukanovaDesign.Models
{
    public class Question
    {
        public readonly string questionTxt;
        public readonly string[] answers;
        public readonly int id;
        public int selectedAnswer;

        public Question(DataManager manager, int id) {
            this.id = id;
            HelperQuestion question = manager.helperQuestionRepository.GetQuestionById(id);
            questionTxt = question.TextOfQuestion;
            answers = manager.helperQuestionRepository.GetAnswersForQuestion(question);
            selectedAnswer = -1;
        } 
    }
}

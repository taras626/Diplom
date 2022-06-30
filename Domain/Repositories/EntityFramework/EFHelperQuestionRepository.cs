using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain.Entites;
using TsukanovaDesign.Domain.Repositories.Abstract;

namespace TsukanovaDesign.Domain.Repositories.EntityFramework
{
    public class EFHelperQuestionRepository : IHelperQuestionRepository
    {
        private readonly AppDBContext context;

        public EFHelperQuestionRepository(AppDBContext context)
        {
            this.context = context;
        }

        public HelperQuestion GetQuestionById(int id)
        {

            return context.HelperQuestions.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<HelperQuestion> GetQuestionsList()
        {
            return context.HelperQuestions;
        }

        public void SaveQuestion(HelperQuestion entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
        }

        public void DeleteQuestion(HelperQuestion entity)
        {
            //IQueryable<QuestionAnswersConnector> qac = context.QuestionAnswersConnectors.Where(x => x.HelperQuestion.Id == entity.Id);

            //List<HelperAnswer> answers = new List<HelperAnswer>();
            //List<HelperAdvice> advices = new List<HelperAdvice>();

            //foreach (HelperAnswer answer in context.HelperAnswers) 
            //{
            //    if (qac.Any(x => x.HelperAnswer.Id == answer.Id)) 
            //    {
            //        advices.Add(answer.HelperAdvice);
            //        answers.Add(answer);
            //    }
            //}

            //context.HelperAdvices.RemoveRange(advices);
            //context.HelperAnswers.RemoveRange(answers);

            //context.QuestionAnswersConnectors.RemoveRange(qac);
            context.HelperQuestions.Remove(entity);

            context.SaveChanges();
        }

        public string[] GetAnswersForQuestion(HelperQuestion entity) 
        {
            List<QuestionAnswersConnector> qac = context.QuestionAnswersConnectors.Where(x => x.HelperQuestionId == entity.Id).ToList<QuestionAnswersConnector>();
            string[] answers = new string[qac.Count()];
            for (int i = 0; i < qac.Count(); i++)
            {
                answers[i] = context.HelperAnswers.FirstOrDefault(x => x.Id == qac[i].HelperAnswerId).TextAnswer;
            }
            return answers;
        }
    }
}

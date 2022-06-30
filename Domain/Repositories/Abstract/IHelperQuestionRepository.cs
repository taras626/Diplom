using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain.Entites;

namespace TsukanovaDesign.Domain.Repositories.Abstract
{
    public interface IHelperQuestionRepository
    {
        public IQueryable<HelperQuestion> GetQuestionsList();
        public string[] GetAnswersForQuestion(HelperQuestion entity);
        public HelperQuestion GetQuestionById(int id);
        public void SaveQuestion(HelperQuestion entity);
        public void DeleteQuestion(HelperQuestion entity);
    }
}

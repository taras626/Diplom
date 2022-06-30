using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain.Entites;

namespace TsukanovaDesign.Domain.Repositories.Abstract
{
    public interface IHelperAnswerRepository
    {
        public IQueryable<HelperAnswer> GetAnswers();
        public HelperAnswer GetAnswerById(int id);
        public void SaveAnswer(HelperAnswer entity);
        public void DeleteAnswer(HelperAnswer entity);
    }
}

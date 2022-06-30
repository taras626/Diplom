using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain.Entites;

namespace TsukanovaDesign.Domain.Repositories.Abstract
{
    public interface IFeedbackRepository
    {
        IQueryable<Feedback> GetFeedbacks();
        Feedback GetFeedbackById(int id);
        void SaveFeedback(Feedback entity);
        void DeleteFeedback(Feedback entity);
    }
}

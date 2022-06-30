using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using TsukanovaDesign.Domain.Repositories.Abstract;

namespace TsukanovaDesign.Domain.Repositories.EntityFramework
{
    public class EFFeedbacksRepository : IFeedbackRepository
    {
        private readonly AppDBContext context;

        public EFFeedbacksRepository(AppDBContext context) => this.context = context;

        public Feedback GetFeedbackById(int id)
        {
            return context.Feedbacks.Single(x=>x.Id == id);
        }

        public IQueryable<Feedback> GetFeedbacks()
        {
            return context.Feedbacks;
        }

        public void SaveFeedback(Feedback entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;

            context.SaveChanges();
        }

        public void DeleteFeedback(Feedback entity)
        {
            context.Feedbacks.Remove(entity);
            context.SaveChanges();
        }
    }
}

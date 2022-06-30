using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain.Entites;
using TsukanovaDesign.Domain.Repositories.Abstract;

namespace TsukanovaDesign.Domain.Repositories.EntityFramework
{
    public class EFHelperAnswerRepository : IHelperAnswerRepository
    {
        public readonly AppDBContext context;

        public EFHelperAnswerRepository(AppDBContext context) => this.context = context;

        public IQueryable<HelperAnswer> GetAnswers()
        {
            return context.HelperAnswers;
        }

        public HelperAnswer GetAnswerById(int id)
        {
            return context.HelperAnswers.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteAnswer(HelperAnswer entity)
        {
            context.HelperAnswers.Remove(entity);
            context.SaveChanges();
        }

        public void SaveAnswer(HelperAnswer entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;

            context.SaveChanges();
        }
    }
}

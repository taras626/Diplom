using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain.Entites;
using TsukanovaDesign.Domain.Repositories.Abstract;

namespace TsukanovaDesign.Domain.Repositories.EntityFramework
{
    public class EFHelperAdviceRepository : IHelperAdviceRepository
    {
        private readonly AppDBContext context;

        public EFHelperAdviceRepository(AppDBContext context) => this.context = context;

        public void DeleteAdvice(HelperAdvice entity) 
        {
            context.HelperAdvices.Remove(entity);
            context.SaveChanges();
        }

        public HelperAdvice GetAdviceById(int id)
        {
            return context.HelperAdvices.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<HelperAdvice> GetAllAdvices()
        {
            return context.HelperAdvices;
        }

        public void SaveAdvice(HelperAdvice entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;

            context.SaveChanges();
        }
    }
}

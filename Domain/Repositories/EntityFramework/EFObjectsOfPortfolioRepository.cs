using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain.Entites;
using TsukanovaDesign.Domain.Repositories.Abstract;

namespace TsukanovaDesign.Domain.Repositories.EntityFramework
{
    public class EFObjectsOfPortfolioRepository : IObjectsOfPortfolioRepository
    {
        private readonly AppDBContext context;

        public EFObjectsOfPortfolioRepository(AppDBContext context) => this.context = context;

        public IQueryable<ObjectOfPortfolio> GetObjectsOfPortfolio()
        {
            return context.ObjectsOfPortfolio;
        }

        public ObjectOfPortfolio GetObjectOfPortfolioById(int id)
        {
            return context.ObjectsOfPortfolio.FirstOrDefault(x => x.Id == id);
        }

        public void SaveObjectOfPortfolio(ObjectOfPortfolio entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;

            context.SaveChanges();
        }

        public void DeleteObjectOfPortfolio(ObjectOfPortfolio entity)
        {
            context.ObjectsOfPortfolio.Remove(entity);
            context.SaveChanges();
        }
    }
}

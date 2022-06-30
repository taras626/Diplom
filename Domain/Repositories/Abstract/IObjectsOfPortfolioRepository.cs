using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain.Entites;

namespace TsukanovaDesign.Domain.Repositories.Abstract
{
    public interface IObjectsOfPortfolioRepository
    {
        IQueryable<ObjectOfPortfolio> GetObjectsOfPortfolio();
        ObjectOfPortfolio GetObjectOfPortfolioById(int id);
        void SaveObjectOfPortfolio(ObjectOfPortfolio entity);
        void DeleteObjectOfPortfolio(ObjectOfPortfolio entity);
    }
}

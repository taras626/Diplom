using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain.Entites;

namespace TsukanovaDesign.Domain.Repositories.Abstract
{
    public interface IHelperAdviceRepository
    {
        public IQueryable<HelperAdvice> GetAllAdvices();
        public HelperAdvice GetAdviceById(int id);
        public void SaveAdvice(HelperAdvice entity);
        public void DeleteAdvice(HelperAdvice entity);
    }
}

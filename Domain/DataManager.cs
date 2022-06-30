using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain.Repositories.Abstract;

namespace TsukanovaDesign.Domain
{
    public class DataManager
    {
        public IFeedbackRepository feedbackRepository;
        public IObjectsOfPortfolioRepository objectsOfPortfolioRepository;
        public IHelperQuestionRepository helperQuestionRepository;
        public IHelperAnswerRepository helperAnswerRepository;
        public IHelperAdviceRepository helperAdviceRepository;

        public DataManager(
            IFeedbackRepository feedback, 
            IObjectsOfPortfolioRepository objectsOfPortfolioRepository, 
            IHelperQuestionRepository helperQuestionRepository, 
            IHelperAnswerRepository helperAnswerRepository, 
            IHelperAdviceRepository helperAdviceRepository
            )
        {
            feedbackRepository = feedback;
            this.objectsOfPortfolioRepository = objectsOfPortfolioRepository;
            this.helperQuestionRepository = helperQuestionRepository;
            this.helperAnswerRepository = helperAnswerRepository;
            this.helperAdviceRepository = helperAdviceRepository;
        }
    }
}

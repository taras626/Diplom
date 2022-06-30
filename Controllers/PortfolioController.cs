using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain;

namespace TsukanovaDesign.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly DataManager dataManager;

        public PortfolioController(DataManager dataManager) => this.dataManager = dataManager;

        public IActionResult Index(int id)
        {
            if (id != default) {
                var model = dataManager.objectsOfPortfolioRepository.GetObjectOfPortfolioById(id);
                return View("PortfolioItem", model);
            }
            var m = dataManager.objectsOfPortfolioRepository.GetObjectsOfPortfolio();
            return View("Index", m);
        }
    }
}

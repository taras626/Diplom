using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukanovaDesign.Domain;
using TsukanovaDesign.Domain.Repositories.EntityFramework;
using TsukanovaDesign.Models;

namespace TsukanovaDesign.Controllers
{
    public class HelperController : Controller
    {
        private readonly DataManager dataManager;
        private List<int> answers;

        public HelperController(DataManager dataManager) => this.dataManager = dataManager; 

        // GET: HelperController
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int id, int idAnswer)            
        {
            if (id != -1)
            {
                var model = new Question(dataManager, (id == default ? 1 : id));
                if (model.answers.Length == 0)
                    return View("Result");                            
                return View("Test", model);
            }
            return View("Error");
        }

        public ActionResult Result() 
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Test(Question model)
        //{
        //    if(model!= null)
        //        return View(model);
        //    return View("Error");
        //}

        //// GET: HelperController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: HelperController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: HelperController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: HelperController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: HelperController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: HelperController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Reviews> reviewRepo;
        public ReviewController(IRepository<Reviews> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }
        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Reviews reviews)
        {
            if (ModelState.IsValid)
            {
                reviewRepo.Create(reviews);
                return RedirectToAction("Details", "Restaurant", new { id = reviews.RestaurantId });
            }
            return View(reviews);
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            Reviews model = reviewRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Reviews reviews)
        {
            if (ModelState.IsValid)
            {
                reviewRepo.Update(reviews);
                return RedirectToAction("Details", "Restaurant", new { id = reviews.RestaurantId });
            }
            return View();
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            Reviews model = reviewRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Reviews review)
        {
            reviewRepo.Delete(review);

            return RedirectToAction("Index");
        }
    }
}

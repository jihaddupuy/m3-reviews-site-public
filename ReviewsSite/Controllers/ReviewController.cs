using Microsoft.AspNetCore.Mvc;
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
                return RedirectToAction("Details", "Restaurant", new {id=reviews.RestaurantId});
            }
            return View(reviews);

        }
    }
}

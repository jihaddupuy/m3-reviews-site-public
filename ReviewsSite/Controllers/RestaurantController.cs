using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class RestaurantController : Controller
    {
        IRepository<Restaurant> restaurantRepo;

        public RestaurantController(IRepository<Restaurant> restaurantRepo)
        {
            this.restaurantRepo = restaurantRepo;
        }
        public ViewResult Index()
        {
           // RestaurantRepository restaurantRepo = new RestaurantRepository();
            var model = restaurantRepo.GetAll();

            return View(model);

        }


        public ViewResult Details(int id)
        {
           // RestaurantRepository restaurantRepo = new RestaurantRepository();

            var model = restaurantRepo.GetById(id);

            return View(model); 

        }

         [HttpGet]
         public ViewResult Create()
         {
                return View();
         }

         [HttpPost]
         public ActionResult Create(Restaurant restaurant)
         {
                if (ModelState.IsValid)
                {
                    restaurantRepo.Create(restaurant);
                    return RedirectToAction("Details");
                }
                return View(restaurant);
         }
    }
}

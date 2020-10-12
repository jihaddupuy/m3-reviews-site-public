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
        public ViewResult Index()
        {
            RestaurantRepository restaurantRepo = new RestaurantRepository();
            var model = restaurantRepo.GetAll();

            return View(model);
        }
    }
}

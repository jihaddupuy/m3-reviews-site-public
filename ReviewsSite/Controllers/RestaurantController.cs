using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
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
            Restaurant restaurant = new Restaurant();
            return View(restaurant);
        }
    }
}

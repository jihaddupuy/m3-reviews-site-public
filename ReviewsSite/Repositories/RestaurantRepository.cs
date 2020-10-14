using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class RestaurantRepository
    {
        public List<Restaurant> restaurantList;
        public RestaurantRepository()
        {
            restaurantList = new List<Restaurant>()
            {
                new Restaurant(1, "Restaurant 1","category","description","review","Image"),
                new Restaurant(2, "Restaurant 2","category","description","review","Image"),
                new Restaurant(3, "Restaurant 3","category","description","review","Image")
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurantList;
        }
        public Restaurant GetById(int id)
        {
            return restaurantList.Single(c => c.Id == id);
        }
            
    }
}

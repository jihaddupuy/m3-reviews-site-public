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
                new Restaurant(1, "Restaurant 1"),
                new Restaurant(2, "Restaurant 2"),
                new Restaurant(3, "Restaurant 3")
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurantList;
        }
        public Restaurant GetByID(int id)
        {
            return restaurantList.Single(c => c.Id == id);
        }
            
    }
}

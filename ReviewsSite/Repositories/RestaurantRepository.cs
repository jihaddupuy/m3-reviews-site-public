using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class RestaurantRepository : IRepository<Restaurant>
    {
        private DiningContext db;
        public RestaurantRepository(DiningContext db)
        {
            this.db = db;
        }
       
        public IEnumerable<Restaurant> GetAll()
        {
            return db.Restaurants;
        }
        public Restaurant GetById(int id)
        {
            return db.Restaurants.Single(c => c.Id == id);
        }
      public void Create(Restaurant restaurant)
        {
            db.Restaurants.Add(restaurant);
            db.SaveChanges();
        }      
    }
}

using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class RestaurantRepository : IRepository<Restaurant>
    {
        public List<Restaurant> restaurantList;
        public RestaurantRepository()
        {
            restaurantList = new List<Restaurant>()
            {
                new Restaurant(1, "bd's Mongolian Grill","Asian BBQ","asian food grilled for you in front of you","one of my favorite places to good for asian grilled food highly recommend","Image"),
                new Restaurant(2, " Ally Cat oyster Bar","Seafood","Cleveland best seafood served on the best patio in town.","Top notch food and setting, the staff was friendly and knowledgable about the variety of seafood. Highly recommended.","Image"),
                new Restaurant(3, "Tommy's on Coventry.","diner","upscale family restaurant","By keeping its focus on balancing its menu between quality meat and vegetable entrees (and at an affordable price) Tommy's achieves its goal of creating  a watering hole where the carnivores and herbivores in your family can graze in peace.","Image")
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

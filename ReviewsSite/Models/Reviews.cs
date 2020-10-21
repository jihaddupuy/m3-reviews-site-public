using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Reviews
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public Reviews()
        {

        }
        

        public Reviews(int id, string content, int restaurantId)
        {
            Id = id;
            Content = content;
            RestaurantId = restaurantId;
        }
    }
}

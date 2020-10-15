using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Reviews
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Restaurant> Restaurants { get; set; }

    }
}

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

        public virtual Restaurant Restaurant { get; set; }

        public int RestaurantId { get; set; }

    }
}

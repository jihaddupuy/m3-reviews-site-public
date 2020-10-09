using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public Restaurant()
        {

        }
        public Restaurant(int id)
        {
            Id = id;
        }
    }
}

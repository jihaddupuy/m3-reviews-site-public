using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Restaurant()
        {

        }
        public Restaurant(int id, string name)
        {
            Id = id;
            Name = name;
        }

        
    }
}

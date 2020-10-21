using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class ReviewsRepository : IRepository<Reviews>
    {
        private DiningContext db;
        public ReviewsRepository(DiningContext db)
        {
            this.db = db;
        }

        public void Create(Reviews obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reviews> GetAll()
        {
            return db.Reviews;
        }
        public Reviews GetById(int id)
        {
            return db.Reviews.Single(c => c.Id == id);
        }

    }
}

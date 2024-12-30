using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UdemyBookStoreProject.DataAccess.Repository.IRepository;
using UdemyBookStoreProject.Models.Models;

namespace UdemyBookStoreProject.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        private ApplicationDbcontext _db;
        public CategoryRepository(ApplicationDbcontext db):base(db) 
        {
                _db = db;
        }
        
        public void Update(Category obj)
        {
           _db.categories.Update(obj);
        }
    }
}

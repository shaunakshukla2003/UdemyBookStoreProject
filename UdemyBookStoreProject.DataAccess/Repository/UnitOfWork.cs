using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyBookStoreProject.DataAccess.Repository.IRepository;

namespace UdemyBookStoreProject.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbcontext _db;
        public ICategoryRepository Category { get; private set; }

        public UnitOfWork(ApplicationDbcontext db) 
        {
            _db = db;
            Category=new CategoryRepository(_db);
        }
        
        public void Save()
        {
            _db.SaveChanges();

        }
    }
}

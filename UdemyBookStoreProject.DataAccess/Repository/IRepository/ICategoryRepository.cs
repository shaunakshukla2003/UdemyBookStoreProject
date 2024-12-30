using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyBookStoreProject.Models.Models;

namespace UdemyBookStoreProject.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository:IRespository<Category>
    {
        void Update(Category obj);
      
    }
}

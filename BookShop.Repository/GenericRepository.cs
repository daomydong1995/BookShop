using BookShop.IRespository;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Repository
{
   public class GenericRepository<T>:IgenericRepository<T> where T:class
    {
        protected BookShopDbContext db { get; set; }
        protected DbSet<T> table = null;

        //Phương thức khởi tạo
        public GenericRepository()
        {
            db = new BookShopDbContext();
            table = db.Set<T>();

        }
        public GenericRepository(BookShopDbContext db)
        {
            this.db = db;
            table = db.Set<T>();

        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(int id)
        {
            return table.Find(id);
        }

        public int Update(T item)
        {
            table.Attach(item);
            db.Entry(item).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public int Delete(int id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
            return db.SaveChanges();
        }

        public int Create(T item)
        {
            table.Add(item);
            return db.SaveChanges();
        }
    }
}

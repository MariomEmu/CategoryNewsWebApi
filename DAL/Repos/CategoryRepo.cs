using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategoryRepo
    {
            static CategoryDBContext db;
            static CategoryRepo()
            {
                db = new CategoryDBContext();
            }
            public static List<Category> Get()
            {
                return db.Categories.ToList();
               
            }
            public static Category Get(int id)
            {
                return db.Categories.Find(id);
            }
            public static bool Create(Category catago)
            {
                db.Categories.Add(catago);
                return db.SaveChanges() > 0;
            }

            public static bool Update(Category catago)
            {
                var exempp = Get(catago.Id);
                db.Entry(exempp).CurrentValues.SetValues(catago);
                return db.SaveChanges() > 0;
            }
            public static bool Delete(int id)
            {
                var exemp = Get(id);
                db.Categories.Remove(exemp);
                return db.SaveChanges() > 0;
            }

        public static bool Create(object data)
        {
            throw new NotImplementedException();
        }
    }
}

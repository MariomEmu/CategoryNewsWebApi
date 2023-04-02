using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class NewsRepo
    {
        static CategoryDBContext db;
        static NewsRepo()
        {
            db = new CategoryDBContext();
        }
        public static List<News> Get()
        {
            return db.News.ToList();

        }
        public static News Get(int id)
        {
            return db.News.Find(id);
        }
        public static bool Create(News news)
        {
            db.News.Add(news);
            return db.SaveChanges() > 0;
        }

        public static bool Update(News news)
        {
            var exempp = Get(news.Id);
            db.Entry(exempp).CurrentValues.SetValues(news);
            return db.SaveChanges() > 0;
        }
        public static bool Delete(int id)
        {
            var exemp = Get(id);
            db.News.Remove(exemp);
            return db.SaveChanges() > 0;
        }

        public static bool Update(object data)
        {
            throw new NotImplementedException();
        }

        public static bool Create(object data)
        {
            throw new NotImplementedException();
        }
    }
}

using BLL.DTOs;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class NewsService
    {
            public static List<NewsDTOs> Get()
            {
                var data = NewsRepo.Get();
                return Convert(data);


            }

            public static List<NewsDTOs> Get10()
            {
                var data = from e in NewsRepo.Get()
                           where e.Id < 11
                           select e;
                return Convert(data.ToList());
            }
            public static NewsDTOs Get(int id)
            {
                return Convert(NewsRepo.Get(id));
            }

            public static bool Create(NewsDTOs news)
            {
            var data = Convert(news);
                return NewsRepo.Create(data);
            }

        private static object Convert(NewsDTOs news)
        {
            throw new NotImplementedException();
        }

        public static bool Update(NewsDTOs news)
            {
                var data = Convert(news);
                return NewsRepo.Update(data);
            }

            public static bool Delete(int id)
            {
                return NewsRepo.Delete(id);
            }

            static List<NewsDTOs> Convert(List<News> news)
            {
                var data = new List<NewsDTOs>();
                foreach (News news1 in news)
                {
                    data.Add(Convert(news1));
                }
                return data;
            }

            static NewsDTOs Convert(News news)
            {
                return new NewsDTOs()
                {
                    Id = news.Id,
                     Title = news.Title,
                    Description = news.Description,
                    CID = news.CID,
                    Data = news.Data
             
                };
            }
        private static Category Convert(CategoryDTOs category)
        {
            return new Category()
            {
                Id = category.Id,
                Name = category.Name
            };
        }



    }
    }


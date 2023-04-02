using BLL.DTOs;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Service
{
    public class CategoryService
    {
        public static List<CategoryDTOs> Get()
        {
            var data = CategoryRepo.Get();
            return Convert(data);


        }

        public static List<CategoryDTOs> Get10()
        {
            var data = from e in CategoryRepo.Get()
                       where e.Id < 11
                       select e;
            return Convert(data.ToList());
        }
        public static CategoryDTOs Get(int id)
        {
            return Convert(CategoryRepo.Get(id));
        }

        public static bool Create(CategoryDTOs category)
        {
            var data = Convert(category);
            return CategoryRepo.Create(data);
        }
        public static bool Update(CategoryDTOs category)
        {
            var data = Convert(category);
            return CategoryRepo.Update(data);
        }

        public static bool Delete(int id)
        {
            return CategoryRepo.Delete(id);
        }

        static List<CategoryDTOs> Convert(List<Category> category)
        {
            var data = new List<CategoryDTOs>();
            foreach (Category categoryes in category)
            {
                data.Add(Convert(categoryes));
            }
            return data;
        }

        static CategoryDTOs Convert(Category category)
        {
            return new CategoryDTOs()
            {
                Id = category.Id,
                Name = category.Name
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
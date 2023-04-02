using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CategoryDTOs
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }

      
    }
}

using RestaurantApp.Core.DTOs.CategoryDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Core.DTOs.ProductDto
{
    public class ResultProductWithCategory : ResultProductDto
    {   
        public ResultCategoryDto Category { get; set; }
    }
}
    
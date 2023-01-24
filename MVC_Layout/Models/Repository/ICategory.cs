using MVC_Layout.Models.Entity;
using System.Collections.Generic;

namespace MVC_Layout.Models.Repository
{
    public interface ICategory
    {
        List<Category> GetCategories();
    }
}

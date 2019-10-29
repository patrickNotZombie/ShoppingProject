using System;
using System.Collections.Generic;
using System.Text;
using Accessory.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Accessory.DataAccess.Data.Repository.IRepository
{
    public interface ICategoryTypeRepository:IRepository<CategoryType>
    {
        IEnumerable<SelectListItem> GetCategoryTypeListDropDown();
        void Update(CategoryType categoryType);
    }
}

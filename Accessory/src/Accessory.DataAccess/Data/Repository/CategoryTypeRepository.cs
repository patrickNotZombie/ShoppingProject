using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accessory.DataAccess.Data.Repository.IRepository;
using Accessory.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Accessory.DataAccess.Data.Repository
{
    public class CategoryTypeRepository : Repository<CategoryType>, ICategoryTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryTypeRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetCategoryTypeListDropDown()
        {
            return _db.CategoryTypes.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
        }

        public void Update(CategoryType objectToBeUpdated)
        {
            var categoryFromDb = _db.CategoryTypes.FirstOrDefault(s => s.Id == objectToBeUpdated.Id);
            categoryFromDb.Name = objectToBeUpdated.Name;
            _db.SaveChanges();
        }

    }
}

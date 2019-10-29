using System;
using System.Collections.Generic;
using System.Text;
using Accessory.Models;

namespace Accessory.DataAccess.Data.Repository.IRepository
{
    public interface IMenuItemRepository : IRepository<MenuItem>
    {
        void Update(MenuItem menuItem);
    }
}

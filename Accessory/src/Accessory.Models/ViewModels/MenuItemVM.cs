using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Accessory.Models.ViewModels
{
    public class MenuItemVM
    {
        public MenuItem MenuItem { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> CategoryTypeList { get; set; }
    }
}

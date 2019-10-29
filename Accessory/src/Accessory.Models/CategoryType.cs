using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Accessory.Models
{
    public class CategoryType
    {
        [Key] public int Id { get; set; }
        [Required]
        [Display(Name = "Kategori Tipi İsmi")]
        public string Name { get; set; }
    }
}

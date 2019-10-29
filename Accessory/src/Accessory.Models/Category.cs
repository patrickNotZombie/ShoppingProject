using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Accessory.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Kategori Adı")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Görüntüleme Sırası")]
        public int DisplayOrder { get; set; }
    }
}

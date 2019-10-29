﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Accessory.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [Range(1,int.MaxValue,ErrorMessage = "Fiyat 5 TL'den büyük olmalı")]
        public double Price { get; set; }
        [Display(Name = "Kategori Türü")] public int CategoryId { get; set; }
        [ForeignKey("CategoryId ")] public virtual Category Category { get; set; }
        [Display(Name = "Parça Türü")] public int CategoryTypeId { get; set; }
        [ForeignKey("CategoryTypeId")] public virtual CategoryType CategoryType { get; set; }
    }
}

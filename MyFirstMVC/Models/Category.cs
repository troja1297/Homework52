﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }

        public IEnumerable<Category> SubCategories { get; set; }

        public IEnumerable<Phone> Phones { get; set; }
    }
}

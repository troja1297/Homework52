using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Укажи название телефона")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Длина названия от 1 до 50")]
        [Remote(action: "ValidateName", controller: "Validation", ErrorMessage = "Не ругайся")]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime FoundationDay { get; set; }

        public IEnumerable<Phone> Phones { get; set; }
    }
}

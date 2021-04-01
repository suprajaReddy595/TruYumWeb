using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TruYumWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Category")]
        public string Name { get; set; }
    }
}
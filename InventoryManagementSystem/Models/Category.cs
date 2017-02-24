using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Models
{
    public class Category
    {
        public Category()
        {

        }
        [Key]
        public int Category_Id { get; set; }
        public String Category_name { get; set; }
        public List<Sub_Category> SubCategories { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Models
{
    public class Size
    {
        public Size()
        {

        }
        [Key]
        public int Size_Id { get; set; }
        public String Size_name { get; set; }
        public List<Product> Products { get; set; }
    }
}
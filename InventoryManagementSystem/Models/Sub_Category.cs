﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Models
{
    public class Sub_Category
    {
        public Sub_Category()
        {

        }
        [Key]
        public int Sub_Category_Id { get; set; }
        public String Sub_Category_name { get; set; }
        public int Category_Id { get; set; }
        public List<Product> Products { get; set; }
    }
}
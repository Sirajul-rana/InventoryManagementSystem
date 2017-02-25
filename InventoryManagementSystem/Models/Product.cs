using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Models
{
    public class Product
    {
        public Product()
        {
        }
        [Key]
        public int Product_Id { get; set; }
        [Required(ErrorMessage = "Product name needed")]
        public String Product_name { get; set; }
        [Required(ErrorMessage = "Product buy price needed")]
        public float Product_buyprice { get; set; }
        [Required(ErrorMessage = "Product sell price needed")]
        public int Product_sellprice { get; set; }
        [Required(ErrorMessage = "Product discount needed")]
        public int Product_discount { get; set; }
        public String Product_picture_path { get; set; }
        [Required(ErrorMessage = "Product quantity needed")]
        public int Product_quantity { get; set; }
        [Required(ErrorMessage = "Product description needed")]
        [DataType(DataType.MultilineText)]
        public string Product_description { get; set; }
        [Required(ErrorMessage = "Product brand name needed")]
        public string Product_brandname { get; set; }
        [Required(ErrorMessage = "Product retailer name needed")]
        public string Product_retailername { get; set; }    

        [Required(ErrorMessage = "Nothing is selected")]
        public int Sub_Category_Id { get; set; }
        public List<Order> Orders { get; set; }
    }
}
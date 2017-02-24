using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Models
{
    public class Order
    {
        public Order()
        {

        }
        [Key]
        public int Order_Id { get; set; }
        public int Quantity { get; set; }

        public int Product_Id { get; set; }
        public int Purches_Id { get; set; }
    }
}
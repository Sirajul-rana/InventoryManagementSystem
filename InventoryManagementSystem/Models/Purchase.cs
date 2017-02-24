using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Models
{
    public class Purchase
    {
        public Purchase()
        {

        }
        [Key]
        public int Purches_Id { get; set; }
        public DateTime Purches_Date_Time { get; set; }
        public float Total { get; set; }
        public int User_Id { get; set; }

        public List<Order> Orders { get; set; }
    }
}
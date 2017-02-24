using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Models
{
    public class Delivery
    {
        public Delivery()
        {
        }
        [Key]
        public int Delivery_Id { get; set; }
        public String Delivery_Address { get; set; }
        public DateTime Delivery_Date_Time { get; set; }
        public int User_Id { get; set; }
        public int Service_Id { get; set; }
    }
}
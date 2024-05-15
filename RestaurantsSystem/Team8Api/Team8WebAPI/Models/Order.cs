﻿using System.ComponentModel.DataAnnotations;

namespace Team8WebAPI.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserID { get; set; }
        public string OrderDetails { get; set; }=string.Empty;
        public string OrderStatus { get; set; } = string.Empty;
        public string OrderType { get; set; }=  string.Empty;
        public string CollectionTime { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public decimal TotalCost { get; set; }
    }
}
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ERP_Project.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity {  get; set; }
        public DateTime? OrderDate { get; set; }

        [Required]
        public int ProductId {  get; set; }

        [JsonIgnore]
        public virtual Product? Product { get; set; }
    }
}
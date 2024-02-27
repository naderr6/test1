﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aulfah.Models
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceID { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string? Status { get; set; }

        public ICollection<Artist> Artists { get; set; } = new List<Artist>();
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();

        [ForeignKey("Orders")]
        public int? OrdersID { get; set; }
        public Orders Orders { get; set; }

    }
}
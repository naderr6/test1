﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Aulfah.Models
{
    public class Artist : User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArtistID { get; set; }
        public string? Skills { get; set; }
        public string? Courses { get; set; }
        public string? socialMedia { get; set; }
        public string? ServicesType { get; set; }
		//public ICollection<Product> Products { get; set; } = new List<Product>();
		public ICollection<Service> Service { get; set; } = new List<Service>();


    }
}

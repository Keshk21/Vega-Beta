using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Models
{
    [Table ("Vehicles")]
    public class Vehicle
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }

        public bool IsRegistered  { get; set; } 
        [Required]
        [MaxLength(255)]
        public string ContactName { get; set; }
         [Required]
        [MaxLength(255)]
        public string ContactPhone { get; set; }
    
        [MaxLength(255)]
        public string ContactEmail { get; set; }
        public string ContactAdress { get; set; }
        public DateTime LastUpdate { get; set; }
        public ICollection<VehcileFeature> Features { get; set; }
        public Vehicle()
        {
            Features = new Collection<VehcileFeature>();
        }

    }
}
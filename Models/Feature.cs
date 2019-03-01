using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Models
{
    [Table("Features")]
    public class Feature
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FeatureName { get; set; }
        public Model Model { get; set; }
        public int ModelId { get; set; }
    }
}
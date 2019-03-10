using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Models
{
    [Table("Models")]
    public class Model
    {
        public int ModelId { get; set; }
         [Required]
        [StringLength (225)]
        public string ModelName { get; set; }
        public Make Make { get; set; }
        public int MakeId { get; set; }
        public ICollection<Feature> Features { get; set; }
        public Model()
        {
            Features =new Collection<Feature>();
        }
    }
}
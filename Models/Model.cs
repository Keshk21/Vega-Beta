using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Models
{
    [Table("Models")]
    public class Model
    {
        public int Id { get; set; }
         [Required]
        [StringLength (225)]
        public string ModelName { get; set; }
        public Make Make { get; set; }
        public int MakeId { get; set; }
    }
}
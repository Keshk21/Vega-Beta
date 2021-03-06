using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Models
{

    public class Make
    {
        public int MakeId { get; set; }
        [Required]
        [StringLength (225)]
        public string MakeName { get; set; }
        public ICollection<Model>  Models { get; set; }
        public Make ()
        {
            Models = new Collection<Model>();
        }   
    
    }
}

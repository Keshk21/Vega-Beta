using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vega.Controllers.Resources
{
    public class MakeResource
    {
        public int Id { get; set; }
        
        public string MakeName { get; set; }
        public ICollection<ModelResource>  Models { get; set; }
        public MakeResource ()
        {
            Models = new Collection<ModelResource>();
        }   
    }
} 
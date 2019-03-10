using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vega.Controllers.Resources
{
    public class ModelResource
    {
        
        public int ModelId { get; set; }
    
        public string ModelName { get; set; }
          public ICollection<FeatureResource>  Features { get; set; }
        public ModelResource ()
        {
            Features = new Collection<FeatureResource>();
        } 
      
    }
}
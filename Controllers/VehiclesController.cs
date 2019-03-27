using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vega.Dal;
using Vega.Models;
using System.Web.Http;


namespace Vega.Controllers
{
    [Route ("Api/Vehicles")]
    public class VehiclesController:Controller
    {
       /* private IMapper mapper;
        private VegaDbContext context;

         public VehiclesController(VegaDbContext context,IMapper mapper)
        {
           this.mapper = mapper;
            this.context = context;
            
        }*/
        [HttpPost]
         [Route ("gg")]
        public IActionResult CreateVehicle(Vehicle vehicle)
        {
            return Ok(vehicle);
        }


        
    }
}
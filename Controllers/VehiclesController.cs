using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vega.Dal;
using Vega.Models;
using System.Web.Http;
using Vega.Controllers.Resources;
using System;

namespace Vega.Controllers
{
    [Route("api/Vehicles")]
    public class VehiclesController : Controller
    {
         private IMapper mapper;
        private readonly VegaDbContext context;

        /* private VegaDbContext context;

public VehiclesController(VegaDbContext context,IMapper mapper)
{
this.mapper = mapper;
this.context = context;
public IMapper Mapper { get;set; }

}*/
        public VehiclesController(IMapper mapper, VegaDbContext context)
        {
            this.mapper = mapper;
            this.context= context;

        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateVehicle([FromBody] VehicleResource vehicleResource)
        {
            var Vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            Vehicle.LastUpdate= DateTime.Now;
            this.context.Vehicles.Add(Vehicle);
             await context.SaveChangesAsync();
           var Result= mapper.Map<Vehicle,VehcileFeature>(Vehicle);

            return Ok(Result);
        }



    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vega.Dal;
using Vega.Models;
using System.Web.Http;
using Vega.Controllers.Resources;
using System;
using Microsoft.EntityFrameworkCore;

namespace Vega.Controllers
{
    [Route("/api/Vehicles")]
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
        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] Vehicle Vehicle)
        {
            if(!ModelState.IsValid)
            return BadRequest(ModelState);

           // var Vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            Vehicle.LastUpdate= DateTime.Now;
            this.context.Vehicles.Add(Vehicle);
             await context.SaveChangesAsync();
           //var Result= mapper.Map<Vehicle,VehcileFeature>(Vehicle);

            return Ok(Vehicle);
        }
         [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVehicle(int id,[FromBody] Vehicle vehicle)
        {
            if(!ModelState.IsValid)
            return BadRequest(ModelState);

             var Vehicle = await context.Vehicles.FindAsync(id);

           // mapper.Map<VehicleResource, Vehicle>(vehicleResource, Vehicle);
            if (Vehicle != null)
            {
            context.Entry(Vehicle).CurrentValues.SetValues(vehicle);
             Vehicle.LastUpdate= DateTime.Now;

            await context.SaveChangesAsync();
            }

             
           //var Result= mapper.Map<Vehicle,VehcileFeature>(Vehicle);

            return Ok(Vehicle);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletVehicle(int id)
        {
            var Vehicle = await context.Vehicles.FindAsync(id);
            if (Vehicle==null )
            return NotFound();

            context.Remove(Vehicle);
           await context.SaveChangesAsync();

            return Ok();

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicle(int id)
        {
             var Vehicle = await context.Vehicles.Include(v=> v.Features).SingleOrDefaultAsync(v=> v.Id==id);

            if (Vehicle==null )
            return NotFound();

            return Ok(Vehicle);
        }
        


    }
}
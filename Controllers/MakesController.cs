using Microsoft.AspNetCore.Mvc;
using Vega.Models;
using System.Collections.Generic;
using Vega.Dal;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AutoMapper;
using Vega.Controllers.Resources;

namespace Vega.Controllers
{

    public class MakesController : Controller
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;
        public MakesController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }
        [HttpGet("/api/Makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ThenInclude(m=> m.Features).ToListAsync();
            return mapper.Map<IList<Make>,List<MakeResource>>(makes);

        }
    }
}
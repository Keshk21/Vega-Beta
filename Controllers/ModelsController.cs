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

    public class ModelsController : Controller
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;
        public ModelsController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }
        [HttpGet("/api/Models")]
        public async Task<IEnumerable<ModelResource>> GetModels()
        {
            var models = await context.Models.Include(m => m.Features).ToListAsync();
            return mapper.Map<IList<Model>,List<ModelResource>>(models);

        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega.Controllers.Resources;
using Vega.Dal;
using Vega.Models;

namespace Vega.Controllers
{
    public class FeatureController:Controller

    {
         private readonly VegaDbContext context;
        private readonly IMapper mapper;
        public FeatureController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }
        [HttpGet("/api/Features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var feature = await context.Features.ToListAsync();
            return mapper.Map<IList<Feature>,List<FeatureResource>>(feature);

        }
    }
}
using AssessmentDotNet2020.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentDotNet2020.Server.Controllers
{
     [ApiController]
     [Route("api/[controller]")]
    public class ColaController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ColaController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet("{id}")]
        public  ActionResult<List<ColaPeople>> Get(int id)
        {
            return context.ColaPeoples.Where(x => x.ColaId == id).ToList();  
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentDotNet2020.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentDotNet2020.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController :ControllerBase
    {
        private readonly ApplicationDbContext context;
        public PeopleController(ApplicationDbContext applicationDbContext)
        {
            this.context = applicationDbContext;
        }
        [HttpGet("{id}")]
        public ActionResult<List<ColaPeople>> Get(int id)
        {
            return context.ColaPeoples.Where(x => x.ColaId == id)
                .ToList();
        }
        [HttpPost]
        public async Task<int> Post(People people)
        {
           
            var query = context.ColaPeoples.Where(
                x => x.status == 0 ).ToList<ColaPeople>();




            var colas = context.Colas
                                          .GroupJoin(
                                                context.ColaPeoples,
                                                colas => colas.Id,
                                                colapeople => colapeople.ColaId,
                                                (colas, colapeople) => new { colas, colapeople }
                                          )
                                          .SelectMany(
                                                x => x.colapeople.DefaultIfEmpty(),
                                                (s, x ) => new { s, x }
                                           ).GroupBy(
                                                     w => new
                                                     {
                                                         ColaId = w.s.colas.Id
                                                     }
                                            ).Select(s => new {
                                                Total = s.Sum(x => x.s.colas.time),
                                                Cola = s.Key.ColaId
                                            }).ToList();


            

            
            var colaRapida = colas.OrderBy(st => st.Total)
                 .First();
          
            


           

            context.Add(people);
            await context.SaveChangesAsync();
            ColaPeople colaPeople = new ColaPeople();
            colaPeople.ColaId = colaRapida.Cola;
            colaPeople.PeopleId = people.Id;

            context.Add(colaPeople);

            await context.SaveChangesAsync();
            return people.Id;
        }
    }
}

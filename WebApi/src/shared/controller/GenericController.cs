using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using WebApi.shared.appDbContext;
using Microsoft.EntityFrameworkCore;


namespace WebApi.shared.controller
{
    public class GenericRestController<T, TRequest> : ControllerBase
        where T : class
        where TRequest : class
    {
        private AppDbContext Context { get; set; }
        private IMapper Mapper { get; set; }

        public GenericRestController(AppDbContext context, IMapper mapper)
        {
            this.Context = context;
            this.Mapper = mapper;
        }

        // GET: /controller
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> GetAll()
        {
            var results = await Context.Set<T>().ToListAsync();
            return Ok(results);
        }

        // GET: /controller/{key}
        [HttpGet("{key}")]
        public async Task<ActionResult<T>> Get(int key)
        {
            var result = await Context.Set<T>().FindAsync(key);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // POST: /controller
        [HttpPost]
        public async Task<ActionResult<T>> Create(TRequest request)
        {
            T db_model = Mapper.Map<TRequest, T>(request);
            var result = await Context.Set<T>().AddAsync(db_model);
            await Context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { key = (result.Entity as dynamic).Id }, result.Entity);
        }

        // PUT: /controller/{key}
        [HttpPut("{key}")]
        public async Task<ActionResult<T>> Update(int key, TRequest request)
        {
            var existingEntity = await Context.Set<T>().FindAsync(key);
            if (existingEntity == null)
            {
                return NotFound();
            }

            // Map the updated properties
            Mapper.Map(request, existingEntity);
            Context.Set<T>().Update(existingEntity);
            await Context.SaveChangesAsync();

            return Ok(existingEntity);
        }

        // DELETE: /controller/{key}
        [HttpDelete("{key}")]
        public async Task<IActionResult> Delete(int key)
        {
            var entity = await Context.Set<T>().FindAsync(key);
            if (entity == null)
            {
                return NotFound();
            }

            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();

            return NoContent();
        }
    }
}

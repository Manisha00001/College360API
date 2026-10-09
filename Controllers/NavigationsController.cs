using College360API.Data;
using College360API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace College360API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NavigationsController : ControllerBase
    {
        private readonly College360DbContext _context;

        public NavigationsController(College360DbContext context)
        {
            _context = context;
        }

        // GET: api/navigations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Navigation>>> GetNavigations()
        {
            return await _context.Navigations.ToListAsync();
        }

        // GET: api/navigations/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Navigation>> GetNavigation(int id)
        {
            var navigation = await _context.Navigations.FindAsync(id);

            if (navigation == null)
            {
                return NotFound();
            }

            return navigation;
        }
    }
}
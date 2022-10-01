using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using trackingapi.Domain.Aggregates.Issue;
using trackingapi.Domain.Common;
using trackingapi.Infrastructure.Data;

namespace trackingapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : ControllerBase
    {
        private readonly IssueDbContext _context;

        public IssueController(IssueDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<IssueAggregate>> Get() => await _context.Issues.ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(IssueAggregate), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid id)
        {
            var issue = await _context.Issues.FindAsync(id);
            return issue == null ? NotFound() : Ok(issue);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create()
        {
            DomainResult<IssueAggregate> dr = IssueAggregate.Create();
            await _context.Issues.AddAsync(dr.DataObject);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new {id = dr.DataObject.Id}, dr.DataObject);
        }

        //[HttpPut("{id}")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public async Task<IActionResult> Update(int id, Issue issue)
        //{
        //    if (id != issue.Id) return BadRequest();
        //    _context.Entry(issue).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var issueToDelete = await _context.Issues.FindAsync(id);
        //    if (issueToDelete == null) return NotFound();

        //    _context.Issues.Remove(issueToDelete);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}
    }
}

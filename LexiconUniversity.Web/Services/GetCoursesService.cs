using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LexiconUniversity.Web.Services
{
    public class GetCoursesService : IGetCoursesService
    {
        private readonly LexiconUniversityContext _context;

        public GetCoursesService(LexiconUniversityContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetCoursesAsync()
        {
            return await _context.Courses.Select(c => new SelectListItem
            {
                Text = c.Title.ToString(),
                Value = c.Id.ToString()
            }).ToListAsync();
        }
    }
}

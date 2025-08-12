using blog_m15.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace blog_m15.Pages.Category
{
    public class IndexModel(AppDBContext _db) : PageModel
    {
        public IEnumerable<CategoryEntiry> Categories { get; set; }
        public async Task OnGet()
        {
            Categories = await _db.Categories.ToListAsync();
        }

        public async Task<IActionResult> OnPost()
        {
            Categories = await _db.Categories.ToListAsync();
            return Page();
        }
    }
}

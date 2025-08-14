using blog_m15.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace blog_m15.Pages.Category
{
    public class EditModel(AppDBContext _db) : PageModel
    {
        [BindProperty]
        public CategoryEntiry Category { get; set; }

        public async Task OnGet(int id)
        {
            Category = await _db.Categories.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var existCate = await _db.Categories.FindAsync(Category.Id);
                existCate.Name = Category.Name;
                await _db.SaveChangesAsync();
                return RedirectToPage("/category/index");
            }

            return Page();
        }
    }
}

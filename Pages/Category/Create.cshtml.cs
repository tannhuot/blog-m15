using blog_m15.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blog_m15.Pages.Category
{
    public class CreateModel(AppDBContext _db) : PageModel
    {
        [BindProperty]
        public CategoryEntiry Category { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost() {

            if (ModelState.IsValid)
            {
                await _db.Categories.AddAsync(Category);
                await _db.SaveChangesAsync();
                return RedirectToPage("/category/index");
            }

            return Page();
        }
    }
}

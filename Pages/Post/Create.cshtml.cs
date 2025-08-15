using blog_m15.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace blog_m15.Pages.Post
{
    public class CreateModel(AppDBContext _db) : PageModel
    {
        [BindProperty]
        public PostEntity Post { get; set; }

        // For Tag <select>
        public SelectList CategoryItems { get; set; }
        [BindProperty]
        public int SelectedCategory { get; set; }

        public IEnumerable<TagEntity> Tags { get; set; }

        [BindProperty]
        public List<int> SelectedTags { get; set; } = new List<int>();

        public async Task OnGet()
        {
            IEnumerable<CategoryEntiry> categories = await _db.Categories.ToListAsync();
            CategoryItems = new SelectList(categories, nameof(CategoryEntiry.Id), nameof(CategoryEntiry.Name));

            Tags = await _db.Tags.ToListAsync();
        }

        public async Task<IActionResult> OnPost()
        {

            await OnGet();
            return Page();
        }
    }
}

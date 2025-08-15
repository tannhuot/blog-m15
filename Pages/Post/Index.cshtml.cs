using blog_m15.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace blog_m15.Pages.Post
{
    public class IndexModel(AppDBContext _db) : PageModel
    {

        public IEnumerable<PostEntity> Posts { get; set; }

        public async Task OnGet()
        {
            Posts = await _db.Posts.ToListAsync();
        }
    }
}

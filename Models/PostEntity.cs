using System.ComponentModel.DataAnnotations.Schema;

namespace blog_m15.Models
{
    public class PostEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }

        // One To Many (One)
        // FK Property
        public int CategoryEntiryId { get; set; }
        // Navigation Reference Property
        public CategoryEntiry Categories { get; set; }

        // Many To Many
        // Navigation Reference Property
        public ICollection<TagEntity> Tags { get; set; }

        [NotMapped]
        public IFormFile Imgfile { get; set; }
    }
}

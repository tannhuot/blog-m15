namespace blog_m15.Models
{
    public class TagEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Many To Many
        // Navigation Reference Property
        public ICollection<PostEntity> Posts { get; set; }
    }
}

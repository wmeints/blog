namespace Blog.Server.Models
{
    using System;

    public class Post
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string FeaturedImage { get; set; }
        public string MobileDoc { get; set; }
        public string Html { get; set; }
        public string PlainText { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DatePublished { get; set; }
        public PublicationStatus Status { get; set; }
        public ApplicationUser Author { get; set; }
        public Category Category { get; set; }
    }
}

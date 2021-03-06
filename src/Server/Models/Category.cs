﻿namespace Blog.Server.Models
{
    using System;

    public class Category
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string FeaturedImage { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}

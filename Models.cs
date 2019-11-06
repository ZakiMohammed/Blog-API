using System;
using System.Collections.Generic;

namespace blog_api
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
        public List<Post> Posts { get; } = new List<Post>();
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public List<Post> Posts { get; } = new List<Post>();
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public List<PostTag> PostTags { get; } = new List<PostTag>();
    }

    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PostTag> PostTags { get; } = new List<PostTag>();
    }

    public class PostTag
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }

}
﻿using NarForumUser.Client.Models.BlogCategory;

namespace NarForumUser.Client.Models.BlogPost;

public class BlogPostVM
{
    public Guid Id { get; set; }
    public int BlogPostId { get; set; }
    public BlogCategoryVM? BlogCategory { get; set; }
    public string? BlogCategoryId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string DisplayContent { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public Guid? UserId { get; set; }
    public int ViewCounter { get; set; }

    public DateTime? DateCreate { get; set; }

    public int CommentCounter { get; set; }
}

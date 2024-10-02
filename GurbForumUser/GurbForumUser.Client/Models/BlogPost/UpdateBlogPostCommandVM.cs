﻿namespace GurbForumUser.Client.Models.BlogPost;

public class UpdateBlogPostCommandVM
{
    public Guid Id { get; set; }
    public Guid BlogCategoryId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}

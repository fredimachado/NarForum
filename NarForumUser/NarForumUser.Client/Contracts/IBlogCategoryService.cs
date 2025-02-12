﻿using NarForumUser.Client.Models;
using NarForumUser.Client.Models.BlogCategory;

namespace NarForumUser.Client.Contracts;

public interface IBlogCategoryService
{
    Task<List<BlogCategoryVM>> GetBlogCategories(GetBlogCategoriesQueryVM request);
    Task<BlogCategoryVM> GetBlogCategory(GetBlogCategoryQueryVM request);
    Task<ApiResponseVM> AddBlogCategory(CreateBlogCategoryCommandVM command);
    Task<ApiResponseVM> UpdateBlogCategory(UpdateBlogCategoryCommandVM command);
    Task<ApiResponseVM> RemoveBlogCategory(RemoveBlogCategoryCommandVM command);
}

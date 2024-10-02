﻿using GurbForumUser.Client.Models;
using GurbForumUser.Client.Models.Category;

namespace GurbForumUser.Client.Contracts
{
    public interface ICategoryService
    {
        // queries
        Task<CategoryVM> GetCategoryByName(string CategoryName);
        Task<CategoryVM> GetCategoryByIntId(int CategoryId);
        Task<List<CategoryVM>> GetCategoriesById(Guid guid);
        Task<List<CategoryVM>> GetCategories();
        Task<List<CategoryVM>> GetSectionCategories();
        Task<List<CategoryVM>> GetCategoriesByName(string CategoryName);
        Task<List<CategoryVM>> GetParentCategoriesByIntId(int CategoryId);

        // commands
        Task<ApiResponseVM> CreateCategory(CategoryVM category);
        Task<ApiResponseVM> UpdateCategory(UpdateCategoryCommandVM category);

    }
}

﻿using AutoMapper;
using BlazorUI.Contracts;
using BlazorUI.Models.Category;
using BlazorUI.Models.Heading;
using BlazorUI.Services.Base;
using BlazorUI.Services.Common;

namespace BlazorUI.Services
{
    public class CategoryService : BaseHttpService, ICategoryService
    {
        private readonly IMapper _mapper;
        public CategoryService(IClient client, IMapper mapper, LocalStorageService localStorage) : base(client, localStorage)
        {
            _mapper = mapper;
        }

        public async Task<ApiResponse<Guid>> CreateCategory(CategoryVM post)
        {
            try
            {
                var createCategoryCommand = _mapper.Map<CreateCategoryCommand>(post);
                await _client.CategoriesAsync(createCategoryCommand);
                return new ApiResponse<Guid>
                {
                    Success = true
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<List<CategoryVM>> GetCategories()
        {
            var posts = await _client.CategoriesAllAsync();
            var data = _mapper.Map<List<CategoryVM>>(posts);

            return data;
        }
    }
}

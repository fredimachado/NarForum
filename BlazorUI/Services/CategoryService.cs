﻿using AutoMapper;
using BlazorUI.Contracts;
using BlazorUI.Models;
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

        public async Task<ApiResponseVM> CreateCategory(CategoryVM post)
        {
            var createCategoryCommand = _mapper.Map<CreateCategoryCommand>(post);
            var data = await _client.CategoriesAsync(createCategoryCommand);

            return _mapper.Map<ApiResponseVM>(data);
        }

        public async Task<List<CategoryVM>> GetCategories()
        {
            var categories = await _client.CategoriesAllAsync();
            var data = _mapper.Map<List<CategoryVM>>(categories);

            return data;
        }

        public async Task<List<CategoryVM>> GetCategoriesByName(string CategoryName)
        {
            var categories = await _client.GetCategoriesByNameAsync(CategoryName);
            var data = _mapper.Map<List<CategoryVM>>(categories);

            return data;

        }

        public async Task<CategoryVM> GetCategoryByName(string CategoryName)
        {
            var category = await _client.GetCategoryByNameAsync(CategoryName);
            var data = _mapper.Map<CategoryVM>(category);

            return data;
        }

        public async Task<List<CategoryVM>> GetParentCategoriesByName(string CategoryName)
        {
            var categories = await _client.GetParentCategoriesByNameAsync(CategoryName);
            var data = _mapper.Map<List<CategoryVM>>(categories);

            return data;
        }

        public async Task<List<CategoryVM>> GetSectionCategories()
        {
            var categories = await _client.GetSectionCategoriesAsync();
            var data = _mapper.Map<List<CategoryVM>>(categories);

            return data;
        }
    }
 }

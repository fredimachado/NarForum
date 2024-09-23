﻿using AdminUI.Models;
using AdminUI.Models.Image;

namespace AdminUI.Contracts
{
    public interface IImageService
    {
        public Task<ApiResponseVM> UploadImageToServer(UploadImageRequestVM request);
        public Task<List<string>> GetImageUrlsFromGallery(string userId, string? dir);
    }
}

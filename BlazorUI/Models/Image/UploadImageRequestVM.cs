﻿using BlazorUI.Models.Enums;
using Microsoft.AspNetCore.Http;

namespace BlazorUI.Models.Image
{
    public class UploadImageRequestVM
    {
        public UploadImageTypeVM Type { get; set; }
        public List<IFormFile>? Files { get; set; }
        public List<string>? FilesBase64 { get; set; }
        public Guid? PostId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? BlogPostId { get; set; }
        public Guid? StaticPageId { get; set; }
        public string? Dir { get; set; }
    }
}

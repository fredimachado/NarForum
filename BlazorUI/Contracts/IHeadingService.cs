﻿using BlazorUI.Models.Heading;
using BlazorUI.Services.Base;

namespace BlazorUI.Contracts
{
    public interface IHeadingService
    {
        // queries
        Task<List<HeadingVM>> GetHeadings();

        // commands
        Task<ApiResponse<Guid>> CreateHeading(HeadingVM post);
    }
}

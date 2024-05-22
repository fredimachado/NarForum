﻿using Application.Contracts.Identity;
using Application.Features.Heading.Queries.GetHeadingsWithPagination;
using Application.Models.Identity.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Identity
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("GetUserInfo")]
        public async Task<UserInfoResponse> Register(UserInfoRequest request)
        {
            return await _userService.GetUserInfo(request);
        }

        [HttpPost("GetUsersWithPagination")]
        public async Task<UsersPaginationDTO> GetUsersWithPagination(GetUsersWithPaginationQuery request)
        {
            return await _userService.GetWithPagination(request);
        }
    }
}

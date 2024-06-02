﻿using Application.Contracts.Identity;
using Application.Models;
using Application.Models.Identity.Role;
using Identity.DatabaseContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Identity.Services
{
    public class RoleService : IRoleService
    {
        private readonly ForumIdentityDbContext _forumIdentityDbContext;

        public RoleService(ForumIdentityDbContext forumIdentityDbContext)
        {
            _forumIdentityDbContext = forumIdentityDbContext;
        }

        public async Task<ApiResponse> AddRole(AddRoleRequest request)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                IdentityRole newRole = new IdentityRole
                {
                    Id = request.Id,
                    Name = request.Name,
                    NormalizedName = request.NormalizedName,
                };

                await _forumIdentityDbContext.Roles.AddAsync(newRole);
                await _forumIdentityDbContext.SaveChangesAsync();

                response.Message = "Role is added";
            }
            catch (Exception ex) 
            {
                response.Message = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }

        public async Task<ApiResponse> UpdateRole(UpdateRoleRequest request)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                var role = await _forumIdentityDbContext.Roles.FirstOrDefaultAsync(x => x.Id == request.Id);

                if (role != null)
                {
                    role.Name = request.Name;
                    role.NormalizedName = request.NormalizedName;


                    _forumIdentityDbContext.Update(role);
                    await _forumIdentityDbContext.SaveChangesAsync();

                    response.Message = "Role is updated";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }


        public async Task<GetUserRolesResponse> GetRoles()
        {
            GetUserRolesResponse response = new GetUserRolesResponse();

            var roles = await _forumIdentityDbContext.Roles.AsNoTracking().Select(x => new UserRoleResponse
            {
                Id = x.Id,
                Name = x.Name,
                NormalizedName = x.NormalizedName,
            }).ToListAsync();

            response.UserRoles = roles;

            return response;
        }
    }
}

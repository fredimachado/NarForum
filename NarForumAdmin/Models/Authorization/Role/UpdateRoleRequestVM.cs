﻿
namespace NarForumAdmin.Models.Authorization.Role;

public class UpdateRoleRequestVM
{
    public string Id { get; set; } = string.Empty;
    public string? Name { get; set; }
    public string? NormalizedName { get; set; }
}

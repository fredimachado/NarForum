﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarForumAdmin.Models.Authorization.Permission;

public class UpdatePermissionDefinitionRequestVM
{
    public string? ParentPermissionDefinitionId { get; set; }
    public string? PermissionDefinitionId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
}

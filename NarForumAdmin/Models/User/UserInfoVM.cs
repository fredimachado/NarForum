﻿namespace NarForumAdmin.Models.User
{
    public class UserInfoVM
    {
        public string? Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime RegisterDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PostCounter { get; set; }
        public int HeadingCounter { get; set; }
        public string? Email { get; set; }
        public bool IsBlocked { get; set; }
        public bool EmailConfirmed { get; set; }

        public string? Role { get; set; }
        public string? Rank { get; set; }
    }
}

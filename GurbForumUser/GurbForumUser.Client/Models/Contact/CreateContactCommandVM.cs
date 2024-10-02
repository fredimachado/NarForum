﻿using GurbForumUser.Client.Models.Enums;

namespace GurbForumUser.Client.Models.Contact
{
    public class CreateContactCommandVM
    {
        public string? NameSurname { get; set; }
        public string? Email { get; set; }
        public string? WebSite { get; set; }
        public ContactTypeVM Type { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
    }
}

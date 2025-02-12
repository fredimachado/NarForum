﻿using NarForumUser.Client.Models.Heading;

namespace NarForumUser.Client.Models.Favorite
{
    public class FavoriteVM
    {
        public Guid Id { get; set; }
        public Guid HeadingId { get; set; }
        public Guid PostId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public Guid? UserId { get; set; }

        public DateTime? DateTime { get; set; }
        public HeadingVM? Heading { get; set; }
    }
}

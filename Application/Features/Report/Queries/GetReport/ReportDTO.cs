﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Report.Queries.GetReport
{
    public class ReportDTO
    {
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public string? Message { get; set; }
        public Guid? SenderUserId { get; set; }
        public string? UserName { get; set; }
        public Guid? PostId { get; set; }
        public Guid? HeadingId { get; set; }
        public int HeadingIndex { get; set; }
    }
}

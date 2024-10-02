﻿using GurbForumUser.Client.Models;
using GurbForumUser.Client.Models.Report;

namespace GurbForumUser.Client.Contracts
{
    public interface IReportService
    {
        Task<List<ReportVM>> GetReports(GetReportsQueryVM request);
        Task<ReportVM> GetReport(GetReportQueryVM request);
        Task<ReportsPaginationVM> GetReportsWithPagination(GetReportsWithPaginationQueryVM request);
        Task<ApiResponseVM> CreateReport(CreateReportCommandVM command);
        Task<ApiResponseVM> RemoveReport(RemoveReportCommandVM command);
    }
}

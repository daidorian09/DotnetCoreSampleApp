using MediatR;
using SampleApp.Application.Internal;
using SampleApp.Data;
using System.Collections.Generic;

namespace SampleApp.Application.Category.Queries.GetAll
{
    public class GetPaginatedCategoryQuery : IRequest<ResponseModel<PaginatedResult<Data.Category>>>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
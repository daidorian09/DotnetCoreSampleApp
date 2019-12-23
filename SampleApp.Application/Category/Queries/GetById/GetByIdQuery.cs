using MediatR;
using SampleApp.Application.Common.Models.Request;
using SampleApp.Data;

namespace SampleApp.Application.Category.Queries.GetById
{
    public class GetByIdQuery : BaseGetByIdRequest, IRequest<ResponseModel<Data.Category>>
    {
    }
}
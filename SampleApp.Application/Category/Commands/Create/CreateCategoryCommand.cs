using MediatR;
using SampleApp.Application.Common.Models;
using SampleApp.Data;

namespace SampleApp.Application.Category.Commands.Create
{
    public class CreateCategoryCommand : BasePrimaryKey, IRequest<ResponseModel<bool>>
    {
        public string ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
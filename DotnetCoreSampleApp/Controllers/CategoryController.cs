using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Application.Category.Commands.Create;
using SampleApp.Application.Category.Queries.GetById;
using SampleApp.Data;
using System.Threading.Tasks;

namespace DotnetCoreSampleApp.Controllers
{
    public class CategoryController : BaseController
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseModel<bool>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] CreateCategoryCommand request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseModel<Category>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get([FromQuery] GetByIdQuery request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }
    }
}
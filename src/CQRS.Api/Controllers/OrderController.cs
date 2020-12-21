using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.Api.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CQRS.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost(template:"makeorder")]
        public IActionResult MakeOrder([FromBody] MakeOrderRequestModel requestModel)
        {
            var response = _mediator.Send(requestModel);
            return Ok(response);

        }

        [HttpGet(template: "order")]
        public IActionResult OrderDetails([FromQuery] GetOrderByIdRequestModel requestModel)
        {
            var response = _mediator.Send(requestModel);
            return Ok(response);

        }
    }
}

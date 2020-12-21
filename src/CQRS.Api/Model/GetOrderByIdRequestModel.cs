using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Api.Model
{
    public class GetOrderByIdRequestModel:IRequest<GetOrderByIdResponseModel>
    {
        public Guid OrderId { get; set; }
    }
}

using CQRS.Api.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Api.Handler
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdRequestModel, GetOrderByIdResponseModel>
    {
        public async Task<GetOrderByIdResponseModel> Handle(GetOrderByIdRequestModel request, CancellationToken cancellationToken)
        {
            var orderDetails = new GetOrderByIdResponseModel()
            {
                Amount = 1.3,
                DateOrder = DateTime.Now,
                OrderId = Guid.NewGuid(),
                OrderName = "order",
                OrderPersonId = Guid.NewGuid(),
                OrderPersonName = "person",
                ProductId = Guid.NewGuid(),
                ProductName = "product",
                Quantity = 5
            };

            return orderDetails;
        }
    }
}

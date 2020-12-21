using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Api.Model
{
    public class GetOrderByIdResponseModel
    {
        public Guid OrderId { get; set; }
        public string OrderName { get; set; }
        public DateTime DateOrder { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public Guid OrderPersonId { get; set; }
        public string ProductName { get; set; }
        public string OrderPersonName { get; set; }
    }
}

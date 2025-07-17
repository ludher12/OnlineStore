using MediatR;
using OnlineStore.Application.Products.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Application.Products.Queries.GetProducts
{
    public class GetProductsQuery : IRequest<List<ProductDto>>
    {
        public string? NameContains { get; set; }
        public float? MinPrice { get; set; }
    }
}

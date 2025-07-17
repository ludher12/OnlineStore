using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Application.Products.Commands.CreateProduct;
using OnlineStore.Application.Products.DTOs;

namespace OnlineStore.WEB.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Create(CreateProductDto createProductDto)
        {
            if (!ModelState.IsValid)
            {
                return View(createProductDto);
            }
            var command = new CreateProductCommand{ Product = createProductDto};
            await _mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }

    }
}

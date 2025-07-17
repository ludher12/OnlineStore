using FluentValidation;
using OnlineStore.Application.Products.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Application.Products.Validators
{
    public class CreateProductValidator : AbstractValidator<CreateProductDto>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Product name is required.")
                .Length(2, 100).WithMessage("Product name must be between 2 and 100 characters.");
            RuleFor(p => p.Price)
                .GreaterThan(0).WithMessage("Product price must be greater than zero.");
            RuleFor(p => p.Stock)
                .GreaterThanOrEqualTo(0).WithMessage("Product stock cannot be negative.");
        }
    }
}

﻿using FluentValidation;
using Northwind.Application.Customers.Commands;

namespace Northwind.Application.Customers.Validators
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(x => x.Id)
                .MaximumLength(5).WithMessage("Customer Id has max. length of 5 characters")
                .NotEmpty().WithMessage("Customer Id is required.");

            RuleFor(x => x.Address).MaximumLength(60);
            RuleFor(x => x.City).MaximumLength(15);
            RuleFor(x => x.CompanyName).MaximumLength(40).NotEmpty();
            RuleFor(x => x.ContactName).MaximumLength(30);
            RuleFor(x => x.ContactTitle).MaximumLength(30);
            RuleFor(x => x.Country).MaximumLength(15);
            RuleFor(x => x.Fax).MaximumLength(24);
            RuleFor(x => x.Phone).MaximumLength(24);
            RuleFor(x => x.PostalCode).MaximumLength(10).NotEmpty();
            RuleFor(x => x.Region).MaximumLength(15);
        }
    }
}

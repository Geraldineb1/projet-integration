using Application.Persistence.Contracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Service.Validators
{
    public class CreateServiceDtoValidator : AbstractValidator<CreateServiceDto>
    {
        private readonly IServiceTypeRepository _serviceTypeRepository;
        private readonly IProviderRepository _providerRepository;
        public CreateServiceDtoValidator(IServiceTypeRepository serviceTypeRepository, IProviderRepository providerRepository)
        {
            _serviceTypeRepository = serviceTypeRepository;
            _providerRepository = providerRepository;

            RuleFor(p => p.Title)
                .NotNull().NotEmpty();
            RuleFor(p => p.Description)
                .NotEmpty().NotNull();
            RuleFor(p => p.Price)
                .GreaterThan(0).NotEmpty().NotNull();
            RuleFor(p =>p.LocationArea).NotEmpty().NotNull();
            RuleFor(p =>p.LocationAddress).NotEmpty().NotNull();
            RuleFor(p =>p.isActive);
            RuleFor(p => p.ServiceTypeId)
                .GreaterThan(0)
                .MustAsync(async (id, token) =>
                {
                    var serviceTypeExists = await _serviceTypeRepository.Exists(id);
                    return !serviceTypeExists;
                }).WithMessage("Does not exist.");
            RuleFor(p => p.ProviderId)
                .GreaterThan(0)
                .MustAsync(async (id, token) =>
                {
                    var providerExists = await _providerRepository.Exists(id);
                    return !providerExists;
                }).WithMessage("Does not exist.");

        }

    }
}

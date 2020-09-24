using Laborit.Domain.Core.Responses;
using Laborit.Domain.Core.Validator;
using Laborit.Infra.Repository.Interfaces;
using Laborit.Service.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laborit.Service.CommandHandlers
{
    public class RemoveBrandCommandHandler : ValidatorResponse, IRequestHandler<BrandCommandDelete, ResponseResult>
    {

        private readonly IUnitOfWork _unitOfWork;

        public RemoveBrandCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseResult> Handle(BrandCommandDelete request, CancellationToken cancellationToken)
        {
            request.Validate();

            if (request.Notifications.Any())
            {
                _response.AddNotifications(request.Notifications);
                return _response;
            }

            var brand = await _unitOfWork.Brands.GetBrandAsync(request.Id);

            await _unitOfWork.Brands.RemoveAsync(brand);
            await _unitOfWork.SaveAsync();
            return _response;
            
        }
    }
}

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
    public class EditBrandHandler : ValidatorResponse, IRequestHandler<BrandCommandEdit, ResponseResult>
    {

        private readonly IUnitOfWork _unitOfWork;

        public EditBrandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async  Task<ResponseResult> Handle(BrandCommandEdit request, CancellationToken cancellationToken)
        {
            request.Validate();

            if (request.Notifications.Any())
            {
                _response.AddNotifications(request.Notifications);
                return _response;
            }
            var brand = await _unitOfWork.Brands.GetBrandAsync(request.Id);
          
            brand.UpdateBrand(request.Name);
           
            await _unitOfWork.SaveAsync();
            return _response;
        }
    }
}

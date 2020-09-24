using Laborit.Domain.Brands;
using Laborit.Domain.Core.Responses;
using Laborit.Domain.Core.Validator;
using Laborit.Infra.Repository.Interfaces;
using Laborit.Service.Commands;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Laborit.Service.CommandHandlers
{
    public class CreateBrandHandler : ValidatorResponse, IRequestHandler<BrandCommandCreate, ResponseResult>
    {

        private readonly IUnitOfWork _unitOfWork;

        public CreateBrandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseResult> Handle(BrandCommandCreate request, CancellationToken cancellationToken)
        {
            request.Validate();

            if (request.Notifications.Any())
            {
                _response.AddNotifications(request.Notifications);
                return _response;
            }
      
            await _unitOfWork.Brands.AddAsync(new Brand(request.Name));
            await _unitOfWork.SaveAsync();
            return _response;
        }
    }
}

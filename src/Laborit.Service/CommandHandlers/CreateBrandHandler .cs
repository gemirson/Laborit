using Laborit.Domain.Core.Responses;
using Laborit.Domain.Core.Validator;
using Laborit.Service.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Laborit.Service.CommandHandlers
{
    public class CreateBrandHandler : ValidatorResponse, IRequestHandler<BrandCommand, ResponseResult>
    {


        public Task<ResponseResult> Handle(BrandCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}

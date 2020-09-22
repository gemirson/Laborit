using Laborit.Domain.Core.Responses;

namespace Laborit.Domain.Core.Validator
{
    public class ValidatorResponse
    {
        protected readonly ResponseResult _response;

        public ValidatorResponse()
        {
            _response = new ResponseResult();
        }
    }
}

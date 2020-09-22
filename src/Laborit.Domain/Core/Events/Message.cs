using Flunt.Notifications;
using Laborit.Domain.Core.Responses;
using MediatR;

namespace Laborit.Domain.Core.Events
{
    public abstract class Message : Notifiable, IRequest<ResponseResult>
    {
        public string MessageType { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}

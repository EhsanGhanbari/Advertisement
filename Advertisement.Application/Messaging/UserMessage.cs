using Advertisement.Application.Infrastructure;
using Advertisement.Application.ViewModel;

namespace Advertisement.Application.Messaging
{
    public class UserMessage : BaseMessage
    {
        public UserViewModel User { get; set; }
    }
}

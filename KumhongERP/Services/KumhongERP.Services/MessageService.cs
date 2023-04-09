using KumhongERP.Services.Interfaces;

namespace KumhongERP.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}

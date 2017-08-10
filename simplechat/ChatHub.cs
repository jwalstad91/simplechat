using Microsoft.AspNet.SignalR;
using simplechat;

namespace simplechat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
    }
}
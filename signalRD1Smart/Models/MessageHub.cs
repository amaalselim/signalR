using Microsoft.AspNetCore.SignalR;

namespace signalRD1Smart.Models
{
    public class MessageHub : Hub
    {
        public async void BroadcastMessage(string message,string user)
        {
            await Clients.All.SendAsync("ReceiveMessage",user,message);   
        }
    }
}

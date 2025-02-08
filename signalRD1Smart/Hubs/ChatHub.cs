using Microsoft.AspNetCore.SignalR;

namespace signalRD1Smart.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string name,string messgae)
        {
            //save in DB
            //send to all online clients
            Clients.All.SendAsync("New Message",name, messgae);    

            //send to others obline clients except me
           // Clients.Others.SendAsync("New Message",name,messgae);   
        }
    }
}

using Microsoft.AspNetCore.SignalR;
using signalRD1Smart.Context;
using signalRD1Smart.Models;

namespace signalRD1Smart.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _context;

        public ChatHub(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task SendMessage(string name,string message)
        {
            try
            {
                //save in DB
                var newMessage = new Message { Sender = name, Content= message };
                _context.Messages.Add(newMessage);
                await _context.SaveChangesAsync();

                //send to all online clients
                await Clients.All.SendAsync("NewMessage", name, message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in ChatHub: {ex.Message}");
            }
           

            //send to others online clients except me
           // Clients.Others.SendAsync("NewMessage",name,message);   
        }
    }
}

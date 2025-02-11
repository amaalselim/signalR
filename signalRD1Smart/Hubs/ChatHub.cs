using Microsoft.AspNetCore.SignalR;
using signalRD1Smart.Context;
using signalRD1Smart.Models;
using System.Text.RegularExpressions;

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
        public async Task joinGroup(string gname,string name)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, gname);

            await Clients.OthersInGroup(gname).SendAsync("NewMember",name, gname);

        }
        public async Task SendToGroup(string gname,string name,string message)
        {
            //save in Db
            await Clients.Group(gname).SendAsync("groupmsg",gname,name,message);
        }
    }
}

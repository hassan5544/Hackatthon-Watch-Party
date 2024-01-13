    using Microsoft.AspNetCore.SignalR;
namespace Hurry_app_Website.Hubs
{

    namespace SignalRChat.Hubs
    {
        public class PartyHub : Hub
        {
            public async Task SendMessage(string user, string message)
            {
                await Clients.All.SendAsync("ReceiveMessage", user, message);
            }
            public async Task NotifyEnter(string Email)
            {
                await Clients.All.SendAsync("UserEntered", Email);
            }
            public async Task Notifyleave(string Email)
            {
                await Clients.All.SendAsync("UserLeft", Email);
            }
            public async Task Play()
            {
                await Clients.All.SendAsync("Played");
            }
            public async Task Pause()
            {
                await Clients.All.SendAsync("Paused");
            }
            public async Task Forward10()
            {
                await Clients.All.SendAsync("Forwarded10");
            }
            public async Task Rewind10()
            {
                await Clients.All.SendAsync("Rewinded10");
            }
        }
    }
}

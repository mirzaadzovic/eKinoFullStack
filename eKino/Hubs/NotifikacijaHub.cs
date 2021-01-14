using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace eKino.Hubs
{
    public class NotifikacijaHub : Hub
    {
        public async Task PosaljiNotifikaciju(string notifikacija)
        {
            await Clients.Caller.SendAsync("PrimiNotificiju", notifikacija);
        }
    }
}

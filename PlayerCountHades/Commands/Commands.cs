using CommandSystem;
using RemoteAdmin;
using System;

namespace PlayerCountHades.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class Commands : ICommand
    {
        public string Command { get; } = "countplayers";

        public string[] Aliases { get; } = { "CP", "cp" };

        public string Description { get; } = "Counts how many players are currently in the server.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender player)
            {
                response = ("Currently playing: " + Handlers.Count.GetPlayerCount());
                return true;
            }
            else 
            {
                response = "something went wrong :(";
                return false; 
            }
        }
    }
}

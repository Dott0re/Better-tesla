﻿using System;
    using System.Linq;

    using CommandSystem;

    using Exiled.API.Features;
    using Exiled.API.Features.Items;

    using RemoteAdmin;
    using Exiled.Permissions.Extensions;

namespace BetterTesla.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class ToggleTeslaTeam : ICommand
    {
        public Handlers Handlers { get; private set; }
       public string Command { get; } = "toggleteslateam";

       public string[] Aliases { get; } = new string[] { "tggttm", "togglettm", "toggleteslatm", "tggteslateam" };

        public string Description { get; } = "A command for disabling teslas for teams";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response) {
            if(!sender.CheckPermission("bettertesla.toggleteslateam")) {
                response = "You can't use that command";
                return false;
            } else if(arguments.Count != 1) {
                response = "Here how you use it: " + "(command) (team)" + "\nCommands that you can use for same function:" + "\ntggtm - togglettm - toggleteslatm - tggteslateam - toggleteslateam" +
                "\nTeams: CHI - MTF - DBOI - SCI - SCP";
                return false;

            } else {
                switch (arguments.At(0)) {
                    case "CHI": 
                      if(Handlers.CHIActivated) {
                           Handlers.CHIActivated = false;
                      } else {
                          Handlers.CHIActivated = true;
                      }
                      response = "The tesla has been toggled for that team";
                      return true;
                    case "MTF":
                        if (Handlers.MTFActivated)
                        {
                            Handlers.MTFActivated = false;
                        }
                        else
                        {
                            Handlers.MTFActivated = true;
                        }
                        response = "The tesla has been toggled for that team";
                        return true;
                    case "SCI":
                        if (Handlers.SciActivated)
                        {
                            Handlers.SciActivated = false;
                        }
                        else
                        {
                            Handlers.SciActivated = true;
                        }
                        response = "The tesla has been toggled for that team";
                        return true;
                        
                    case "DBoi":
                        if (Handlers.DBoiActivated)
                        {
                            Handlers.DBoiActivated = false;
                        }
                        else
                        {
                            Handlers.DBoiActivated = true;
                        }
                        response = "The tesla has been toggled for that team";
                        return true;
                        
                    case "SCP":
                        if (Handlers.SCPActivated)
                        {
                            Handlers.SCPActivated = false;
                        }
                        else
                        {
                            Handlers.SCPActivated = true;
                        }
                        response = "The tesla has been toggled for that team";
                        return true;
                        
                    default: 
                        response = "Inexistent Team" + "\nTeams: CHI - MTF - DBOI - SCI - SCP";
                        return false;
                }

            }
        }

    }
}

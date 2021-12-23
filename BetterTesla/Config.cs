﻿using Exiled.API.Interfaces;
using System.ComponentModel;
using BC = Exiled.API.Features.Broadcast;
using System.Collections.Generic;

namespace BetterTesla
{
    public class Config : IConfig
    {
        [Description("Enable/Disable the Plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Teams that should not active the teslas. Teams here: https://controlc.com/4ff2b452")]
        public List<Team> NoTriggerTesla { get; set; } = new List<Team>() { Team.MTF };

        [Description("Is BroadCast Enabled for bypassing tesla for MTF? (default = true) [true/false]")]
        public bool TeslaMTFBC { get; set; } = true;

        [Description("Is BroadCast Enabled for bypassing tesla for CHI? (default = true) [true/false]")]
        public bool TeslaCHIBC { get; set; } = true;

        [Description("To Make Change To The Broadcast to the MTF")]
        public BC TeslaMTF { get; set; } = new BC(" <b><color=red> TESLA GATE DISABLED FOR MTF </color></b>");

        [Description("To Make Change To The Broadcast to the CHI")]
        public BC TeslaCHI { get; set; } = new BC(" <b><color=green> TESLA GATE DISABLED FOR CHI </color></b>");

        [Description("There is an Item that bypass the Teslas? (default = false) [true/false]")]
        public bool IfBypassTeslaItem { get; set; } = false;

        [Description("If there is a bypassteslaitem, what is that? (default = coin) Example: Coin. List (Pick the Name):https://pastebin.com/RUT27JBU")]
        public ItemType BypassTeslaItem { get; set; }= ItemType.Coin;

        [Description("Broadcast pickup item")]
        public Exiled.API.Features.Broadcast PickItemBC { get; set; } = new Exiled.API.Features.Broadcast(" <color=white> THIS ITEM WILL BYPASS TESLA </color>");

        [Description("Cost for using Tesla for SCP 079 (default = 50)")]
        public int TeslaCost079 { get; set; } = 50;

        [Description("When a player dies by tesla, it should erase his inventory? (default = false)")]
        public bool InventoryErase { get; set; } = false;

        [Description("Has 079 a limit for how many teslas it can trigger? (default = false)")]
        public bool IfTesla079Limit { get; set; } = false;

        [Description("If Teslas079Limit is true, set the limit for 079 (default = 15)")]
        public int Tesla079Limit { get; set; }= 15;

        [Description("If there isn't any SCP left, should be the teslas disabled? (default = false)")]
        public bool TeslaDisableAtNoScp { get; set; }= false;
    }
}
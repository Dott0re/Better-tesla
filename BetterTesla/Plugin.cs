﻿using Exiled.API.Features;
using PlayerEvents = Exiled.Events.Handlers.Player;
using ServerEvents = Exiled.Events.Handlers.Server;
using HandlersS = Exiled.Events.Handlers;
using Effect = CustomPlayerEffects.Deafened;
using Effect1 = CustomPlayerEffects.Burned;


namespace BetterTesla
{
    public class Plugin : Plugin<Config>
    {
        public Handlers Handlers { get; private set; }

        public static Plugin Singleton;

        public override void OnEnabled()
        {
            Singleton = this;

            Handlers = new Handlers();
            RegisterEvents();
            base.OnEnabled();
            Handlers.TeslaTimes = 0;
            Handlers.ActivatedTeslas = true;
        }

        

        public override void OnDisabled()
        {
            UnregisterEvents();
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            Handlers = new Handlers();          
            PlayerEvents.TriggeringTesla += Handlers.OnTriggeringTesla;
            PlayerEvents.PickingUpItem += Handlers.PickItem;
            PlayerEvents.Dying += Handlers.Dying;
            Exiled.Events.Handlers.Scp079.InteractingTesla += Handlers.Interact079Tesla;
            PlayerEvents.ChangingRole += Handlers.ChangingRole;
            ServerEvents.RoundStarted += Handlers.OnStartedRound;
            PlayerEvents.Died += Handlers.Died;
            
            


        }


        private void UnregisterEvents()
        {
            PlayerEvents.TriggeringTesla -= Handlers.OnTriggeringTesla; //using *nome a caso* = Exiled.Events.Handlers.Scp079; serve per registrare gli eventi 
            Handlers.TeslaTimes = 0;     
            PlayerEvents.PickingUpItem -= Handlers.PickItem;
            PlayerEvents.Dying -= Handlers.Dying;
            Exiled.Events.Handlers.Scp079.InteractingTesla -= Handlers.Interact079Tesla;
            PlayerEvents.ChangingRole -= Handlers.ChangingRole;
            ServerEvents.RoundStarted -= Handlers.OnStartedRound;
            PlayerEvents.Died -= Handlers.Died;


            Handlers = null;
            
        }
    }
}
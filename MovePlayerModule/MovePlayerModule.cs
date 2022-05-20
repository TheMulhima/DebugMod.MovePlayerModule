using System;
using System.Collections;
using System.Linq;
using DebugMod;
using Modding;
using MonoMod;
using UnityEngine;

namespace MovePlayerModule
{
    public class MovePlayerModule: Mod
    {
        public override string GetVersion() => "1";
        
        public override void Initialize()
        {
            if (AppDomain.CurrentDomain.GetAssemblies().Select(x => x.GetName().Name).Contains("DebugMod"))
            {
                AddStuffToDebug();
            };
        }

        private void AddStuffToDebug()
        {
            DebugMod.DebugMod.AddToKeyBindList(typeof(KeyBinds));
        }
    }
}
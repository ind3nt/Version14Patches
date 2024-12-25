using System;
using Exiled.API.Features;
using HarmonyLib;

namespace _14_Patches
{
    internal class Plugin : Plugin<Config>
    {
        public override string Author => "sky3z";

        public override string Name => "Version14Patches";

        public override string Prefix => "v14_Patches";

        public override Version Version => base.Version;

        public static Plugin Instance { get; private set; }

        public static Harmony harmony;

        private int _patchesCounter;

        public override void OnEnabled()
        {
            base.OnEnabled();

            Instance = this;

            Patch();
        }

        public override void OnDisabled()   
        {
            base.OnDisabled();

            Instance = null;

            UnPatch();
        }

        private void Patch()
        {
            try
            {
                harmony = new Harmony($"14_Patches.{++_patchesCounter}");

                var lastDebugStatus = Harmony.DEBUG;
                Harmony.DEBUG = true;

                harmony.PatchAll();

                Harmony.DEBUG = lastDebugStatus;

                Log.Debug("Patching was successful!");
            }
            catch (Exception e) 
            {
                Log.Error($"Patching error! {e}");
            }
        }

        private void UnPatch()
        {
            harmony.UnpatchAll();

            Log.Debug("Unpatch was successful!");
        }
    }
}

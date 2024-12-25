using HarmonyLib;

namespace _14_Patches.Patches
{
    [HarmonyPatch(typeof(SnowballDamageHandler))]
    [HarmonyPatch(nameof(SnowballDamageHandler.ApplyDamage))]

    internal static class SnowballPatch
    {
        static bool Prefix()
        {
            return false;
        }
    }
}
    
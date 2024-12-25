using HarmonyLib;

namespace _14_Patches.Patches
{
    [HarmonyPatch(typeof(DeadmanSwitch))]
    [HarmonyPatch(nameof(DeadmanSwitch.OnUpdate))]

    internal static class DeadmanPatch
    {
        static bool Prefix()
        {
            return false;
        }
    }
}

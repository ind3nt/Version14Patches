using HarmonyLib;
using Christmas.Scp2536;

namespace _14_Patches.Patches
{
    [HarmonyPatch(typeof(Scp2536Controller))]
    [HarmonyPatch(nameof(Scp2536Controller.Awake))]

    internal static class Scp2536Patch
    {
        static bool Prefix()
        {
            return false;
        }
    }
}

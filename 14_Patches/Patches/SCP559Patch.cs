using HarmonyLib;

namespace _14_Patches.Patches
{
    [HarmonyPatch(typeof(Scp559Cake))]
    [HarmonyPatch(nameof(Scp559Cake.CanSpawn))]

    internal static class Scp559Patch
    {
        static bool Prefix()
        {
            return false;
        }
    }
}

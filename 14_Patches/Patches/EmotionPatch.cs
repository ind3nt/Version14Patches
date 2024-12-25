using HarmonyLib;
using PlayerRoles.FirstPersonControl.Thirdperson.Subcontrollers;

namespace _14_Patches.Patches
{
    [HarmonyPatch(typeof(EmotionSync))]
    [HarmonyPatch(nameof(EmotionSync.ServerSetEmotionPreset))]

    internal static class EmotionPatch
    {
        static bool Prefix()
        {
            return false;
        }
    }
}

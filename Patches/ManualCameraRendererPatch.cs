using HarmonyLib;

namespace NoLostSignal.Patches
{
    [HarmonyPatch(typeof(ManualCameraRenderer))]
    public class ManualCameraRendererPatch
    {
        [HarmonyPatch("ChickIfPlayerIsInCaves")]
        [HarmonyPrefix]
        private static bool CheckIfPlayerIsInCavesPatch(ManualCameraRenderer __instance)
        {
            return false;
        }
    }
}

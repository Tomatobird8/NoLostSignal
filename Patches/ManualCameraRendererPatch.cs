using HarmonyLib;

namespace NoLostSignal.Patches
{
    [HarmonyPatch(typeof(ManualCameraRenderer))]
    public class ManualCameraRendererPatch
    {
        [HarmonyPatch("CheckIfPlayerIsInCaves")]
        [HarmonyPrefix]
        private static bool CheckIfPlayerIsInCavesPatch(ManualCameraRenderer __instance)
        {
            return false;
        }
    }
}

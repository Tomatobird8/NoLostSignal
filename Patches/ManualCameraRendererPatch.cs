using HarmonyLib;

namespace NoLostSignal.Patches
{
    [HarmonyPatch(typeof(ManualCameraRenderer))]
    public class ManualCameraRendererPatch
    {
        [HarmonyPatch("CheckIfPlayerIsInCaves")]
        [HarmonyPatch("CheckIfPlayerIsInCavesInstantly")]
        [HarmonyPrefix]
        private static bool CheckIfPlayerIsInCavesPatch()
        {
            return false;
        }
    }
}

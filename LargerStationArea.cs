using HarmonyLib;
using VoxelTycoon.Tracks;

public class LargerStationAreaMod : VoxelTycoon.Modding.Mod
{
    protected override void Initialize()
    {
        var harmony = new Harmony("kamikaze_fish.larger_station_area");
        harmony.PatchAll();
    }
}

[HarmonyPatch(typeof(VehicleStation), "Range", MethodType.Getter)]
class VehicleStation_getRange_LargerStationAreaPatch
{
    static void Postfix(ref int __result)
    {
        __result = 2 * __result;
    }
}

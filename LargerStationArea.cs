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
    static void Postfix(ref float __result)
    {
        __result = 41.0f;
    }
}

[HarmonyPatch(typeof(VehicleStation), "InnerRange", MethodType.Getter)]
class VehicleStation_InnerRange_LargerStationAreaPatch
{
    static void Postfix(ref float __result)
    {
        __result = 21.0f;
    }
}

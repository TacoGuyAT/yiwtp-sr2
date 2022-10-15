using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace YesIWantToPlay.Loaders;
[BepInPlugin("com.korfex.TacoGuyAT.YIWTP", "YesIWantToPlay", "0.1.0")]
public class YIWTPBepInEx : BasePlugin {
    public HarmonyLib.Harmony Harmony;
    public override void Load() {
        Harmony = new HarmonyLib.Harmony("com.korfex.TacoGuyAT.YIWTP");
        Harmony.PatchAll();
        Log.LogInfo("patched, glhf");
    }
}

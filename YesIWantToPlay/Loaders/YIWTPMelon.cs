using MelonLoader;
using System;

[assembly: MelonInfo(typeof(YesIWantToPlay.Loaders.YIWTPMelon), "YesIWantToPlay", "0.1.0", "__tacoguy", "https://github.com/TacoGuyAT/yiwtp-sr2")]
[assembly: MelonColor(ConsoleColor.DarkYellow)]
[assembly: MelonOptionalDependencies("BepInEx.Core", "BepInEx.Unity.IL2CPP")]

namespace YesIWantToPlay.Loaders;
public class YIWTPMelon : MelonMod {
    public override void OnInitializeMelon() {
        LoggerInstance.Msg("patched, glhf");
    }
}

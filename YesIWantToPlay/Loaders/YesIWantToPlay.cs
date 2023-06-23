using MelonLoader;

[assembly: MelonInfo(typeof(YesIWantToPlay.Loaders.YIWTPMelon), "YesIWantToPlay", 0, 2, 0, "__tacoguy", "https://github.com/TacoGuyAT/yiwtp-sr2")]
[assembly: MelonColor(255, 255, 255, 0)]

namespace YesIWantToPlay.Loaders;
public class YIWTPMelon : MelonMod {
    public override void OnInitializeMelon() {
        LoggerInstance.Msg("patched, glhf");
    }
}
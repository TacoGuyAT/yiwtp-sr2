using HarmonyLib;
using Il2CppMonomiPark.SlimeRancher.UI;
using Il2CppMonomiPark.SlimeRancher.UI.MainMenu;
using UnityEngine.InputSystem;

namespace YesIWantToPlay.Patches;

[HarmonyPatch(typeof(CompanyLogoScene))]
public class CompanyLogoScenePatch {
    [HarmonyPostfix]
    [HarmonyPatch("OnMainMenuLoaded")]
    static void OnMainMenuLoaded_Postfix() {
        var prompt = UnityEngine.Object.FindObjectOfType<PlatformEngagementPrompt>();
        prompt.engagementPromptTextUI.SetActive(false);
        var actions = prompt.submitAction.action.m_OnPerformed;
        // There should be only one action, but just in case...
        for(int i = 0; i < actions.length; i++)
            actions[i].Invoke(new InputAction.CallbackContext());
    }
}

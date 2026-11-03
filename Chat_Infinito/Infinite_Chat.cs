using HarmonyLib;
using TMPro;

namespace MeuModAmongUs
{
    [HarmonyPatch(typeof(ChatController), nameof(ChatController.Awake))]
    public class CustomChatLimitPatch
    {
        public static void Postfix(ChatController __instance)
        {
            if (__instance.textArea != null)
            {
                
                __instance.textArea.characterLimit = 1200;
            }
        }
    }
}
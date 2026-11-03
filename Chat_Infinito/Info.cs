using HarmonyLib;

namespace Info
{
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.RpcSyncSettings))]
    public class CustomGameSettingsPatch
    {
        public static void Postfix(PlayerControl __instance)
        {
            if (AmongUsClient.Instance.AmHost && GameOptionsManager.Instance != null)
            {
                var options = GameOptionsManager.Instance.CurrentGameOptions;

                if (options != null)
                {
                    options.SetInt(Int32OptionNames.NumCommonTasks, 2);
                    options.SetInt(Int32OptionNames.NumLongTasks, 3);
                    options.SetInt(Int32OptionNames.NumShortTasks, 5);
                    options.SetBool(BoolOptionNames.VisualTasks, true);
                    options.SetBool(BoolOptionNames.ConfirmEjects, true);
                    options.SetInt(Int32OptionNames.DiscussionTime, 15);
                    options.SetInt(Int32OptionNames.VotingTime, 120);
                    options.SetFloat(FloatOptionNames.PlayerSpeedMod, 1.5f);
                    options.SetFloat(FloatOptionNames.CrewLightMod, 1.0f);
                    options.SetFloat(FloatOptionNames.ImpostorLightMod, 1.5f);
                    options.SetFloat(FloatOptionNames.KillCooldown, 22.5f);
                }
            }
        }
    }
}
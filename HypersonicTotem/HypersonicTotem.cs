using MelonLoader;
using BTD_Mod_Helper;
using HypersonicTotem;

[assembly: MelonInfo(typeof(HypersonicTotem.HypersonicTotem), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace HypersonicTotem;

public class HypersonicTotem : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<HypersonicTotem>("HypersonicTotem loaded!");
    }
}
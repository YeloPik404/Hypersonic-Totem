using MelonLoader;
using BTD_Mod_Helper;
using HypersonicTotem;
using Assets.Scripts.Models.GenericBehaviors;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Unity.UI_New.InGame;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Harmony;


[assembly: MelonInfo(typeof(HypersonicTotem.HypersonicTotem), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace HypersonicTotem{
    class Main : BloonsMod
{
    public class hypersonicTotem : ModTower
    {
        public override string Name => "HypersonicTotem";
        public override string DisplayName => "Hypersonic Totem";
        public override string Description => "An ancient and powerful variant of the energising totem that can make any tower that gets near this sacred totem will attack at hypersonic speeds!";
        public override string BaseTower => "EnergisingTotem";
        public override int Cost => 1000000;
        public override int TopPathUpgrades => 0;
        public override int MiddlePathUpgrades => 0;
        public override int BottomPathUpgrades => 0;
        public override string TowerSet => "Support";
        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.display = "65bf98ead18ff0643b31acfd2736ce57";
            towerModel.GetBehavior<DisplayModel>().display = "65bf98ead18ff0643b31acfd2736ce57";
            towerModel.GetBehavior<RateSupportModel>().multiplier = -9999999;
        }

        public override string Icon => "Hypersonictotem_Icon";
        public override string Portrait => "Hypersonictotem_portrait";
    }

    public class HypersonicTotem : BloonsTD6Mod
    {
        public override void OnApplicationStart()
        {
            ModHelper.Msg<HypersonicTotem>("HypersonicTotem loaded!");
        }
    }
} }
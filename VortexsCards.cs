﻿using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using VortexsCards.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;


namespace VortexsCards
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class VortexsCards : BaseUnityPlugin
    {
        private const string ModId = "com.Vortex.rounds.VortexsCards";
        private const string ModName = "Vortex's Cards";
        public const string Version = "1.0.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "VC";

        public static VortexsCards instance { get; private set; }


        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;
            CustomCard.BuildCard<InfiniteAmmo>(); // Copy for every card
            CustomCard.BuildCard<BouncyTradeoff>();
            CustomCard.BuildCard<FloatyPunch>();
            CustomCard.BuildCard<IgnoreWalls>();
            CustomCard.BuildCard<PurpleBullets>();
        }
    }
}

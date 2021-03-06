﻿using RimWorld;
using Verse;

namespace HumanResources
{
    [DefOf]
    public static class TechDefOf
    {
        public static RecipeDef 
            LearnTech,
            DocumentTech,
            TrainWeaponShooting,
            TrainWeaponMelee,
            PracticeShooting,
            PracticeMelee;
        public static ThingCategoryDef Knowledge;
        public static StuffCategoryDef Technic;
        public static ThingDef 
            TechBook,
            UnfinishedTechBook;
        public static WorkTypeDef HR_Learn;
    }
}

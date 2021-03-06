﻿using HarmonyLib;
using System;
using Verse;

namespace HumanResources
{
    //If a book is added to book shelf, discover corresponding tech.
    [HarmonyPatch(typeof(ThingOwner), "NotifyAdded")]
    public static class ThingOwner_NotifyAdded
    {
        public static void Postfix(Thing item, IThingHolder ___owner)
        {
            if (___owner is Building_BookStore bookStore && item.Stuff != null && item.Stuff.IsWithinCategory(TechDefOf.Knowledge))
            {
                ResearchProjectDef project = ModBaseHumanResources.unlocked.techByStuff[item.Stuff];
                bookStore.CompStorageGraphic.UpdateGraphics();
                project.CarefullyFinishProject(bookStore);
            }
        }
    }
}

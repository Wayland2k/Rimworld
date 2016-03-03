﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;   // Always needed
//using VerseBase;   // Material/Graphics handling functions are found here
using RimWorld;      // RimWorld specific functions are found here
using Verse;         // RimWorld universal objects are here
//using Verse.AI;    // Needed when you do something with the AI
//using Verse.Sound; // Needed when you do something with the Sound

namespace OutpostGenerator
{
    /// <summary>
    /// OG_Inhabitants class.
    /// </summary>
    /// <author>Rikiki</author>
    /// <permission>Use this code as you want, just remember to add a link to the corresponding Ludeon forum mod release thread.
    /// Remember learning is always better than just copy/paste...</permission>
    public class Designator_AreaAllowedExpandExceptedOutpost : Designator_AreaAllowedExpand
    {
        public override AcceptanceReport CanDesignateCell(IntVec3 c)
        {
            Log.Message("Designator_AreaAllowed.SelectedArea.Label = " + Designator_AreaAllowed.SelectedArea.Label);
            bool designationIsValid = (Designator_AreaAllowed.SelectedArea != null)
                && (Designator_AreaAllowed.SelectedArea.Label != OG_Util.OutpostAreaLabel);
            if (designationIsValid)
            {
                return base.CanDesignateCell(c).Accepted;
            }
            Messages.Message("You cannot expand M&Co. Outpost area.", MessageSound.RejectInput);
            return AcceptanceReport.WasRejected;
        }
    }
}

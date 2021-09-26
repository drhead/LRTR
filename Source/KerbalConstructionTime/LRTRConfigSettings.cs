﻿using System.Collections.Generic;
using UnityEngine;

namespace KerbalConstructionTime
{
    public class LRTRHomeWorldParameters : IConfigNode
    {
        [Persistent]
        public double karmanAltitude = FlightGlobals.GetHomeBody().atmosphereDepth;
        public double hoursPerDay = KSPUtil.dateTimeFormatter.Day / 3600;
        public double daysPerYear = KSPUtil.dateTimeFormatter.Year / KSPUtil.dateTimeFormatter.Day;

        public void Load(ConfigNode node)
        {
            ConfigNode.LoadObjectFromConfig(this, node);
        }

        public void Save(ConfigNode node)
        {
            ConfigNode.CreateConfigFromObject(this, node);
        }
    }
}
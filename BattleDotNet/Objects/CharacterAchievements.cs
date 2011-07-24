﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects
{
    public class CharacterAchievements
    {
        [JsonProperty("achievementsCompleted")]
        public IEnumerable<int> CompletedAchievementIDs { get; private set; }

        [JsonProperty("criteria")]
        public IEnumerable<int> CriteriaIDs { get; private set; }

        [JsonProperty("criteriaQuantity")]
        public IEnumerable<long> CriteriaQuantities { get; private set; }
    }
}
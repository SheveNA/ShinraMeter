using System;
using System.Collections.Generic;

namespace Tera.DamageMeter
{
    public class SkillsStats
    {
        public Dictionary<KeyValuePair<int, string>, SkillStats> _skills =
            new Dictionary<KeyValuePair<int, string>, SkillStats>();

        public SkillsStats()
        {
        }


        public SkillsStats(PlayerInfo playerInfo)
        {
            PlayerInfo = playerInfo;
        }

        public Dictionary<KeyValuePair<int, string>, SkillStats> Skills
        {
            get { return _skills; }
            set { _skills = value; }
        }

        public PlayerInfo PlayerInfo { get; }


        public long Damage
        {
            get
            {
                long damage = 0;
                foreach (var skill in Skills)
                {
                    damage += skill.Value.Damage;
                }
                return damage;
            }
        }

        public double CritRate
        {
            get
            {
                var crit = 0;
                var hits = 0;
                foreach (var skill in Skills)
                {
                    crit += skill.Value.Crits;
                    hits += skill.Value.Hits;
                }

                if (hits == 0)
                {
                    return 0;
                }
                return Math.Round((double) crit*100/hits, 1);
            }
        }
    }
}
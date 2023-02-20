using System;
using System.Collections.Generic;

namespace WpfApp1
{
    [Serializable]
    public class BackUp
    {
        public string ExtraEx { get; set; }

        public string AmmoCo { get; set; }

        public string LootValueMU { get; set; }

        public string EnKill { get; set; }

        public string LootValue { get; set; }


        public BackUp(string _extraex, string _ammoco, string _lootvaluemu, string _enkill, string _lootvalue)
        {
            this.ExtraEx = _extraex;
            this.AmmoCo = _ammoco;
            this.LootValueMU = _lootvaluemu;
            this.EnKill = _enkill;
            this.LootValue = _lootvalue;
        }
    }
}


namespace WpfApp1
{
    [Serializable]
    internal class BackUpConfig
    {
        public List<BackUp> BackUpList;
    }
}

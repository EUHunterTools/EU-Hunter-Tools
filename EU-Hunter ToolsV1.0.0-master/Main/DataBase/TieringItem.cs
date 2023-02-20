namespace WpfApp1
{
    public class TieringItems
    {
        public string ITEM { get; set; }

        public double TIER { get; set; }

        public int USES { get; set; }

        public double AMMOFROMLASTTIER { get; set; }

        public string DATE { get; set; }

        public TieringItems(string _item, double _tier, int _uses, double _ammo_from_last_tier, string _date)
        {
            ITEM = _item;
            TIER = _tier;
            USES = _uses;
            AMMOFROMLASTTIER = _ammo_from_last_tier;
            DATE = _date;
        }
    }
}

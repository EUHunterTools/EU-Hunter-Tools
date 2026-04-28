namespace WpfApp1
{
    public class StatusItems
    {
        public string ITEM { get; set; }

        public int USES { get; set; }

        public double PEDCYCLED { get; set; }

        public double DMGDONE { get; set; }

       

        public StatusItems(string _item, int _uses, double _ped_cycled, double _dmg_done)
        {
            ITEM = _item;
            USES = _uses;
            PEDCYCLED = _ped_cycled;
            DMGDONE = _dmg_done;            
        }
    }
}

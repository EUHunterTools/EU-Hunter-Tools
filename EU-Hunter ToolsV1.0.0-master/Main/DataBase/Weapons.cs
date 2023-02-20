using System.Collections;
using System.IO;

namespace WpfApp1
{
    public class Weapons
    {
        public string NAME { get; set; }
        public string CLASS { get; set; }
        public string TYPE { get; set; }
        public string RANGE { get; set; }
        public string DAMAGE { get; set; }
        public string ATTACKS { get; set; }
        public string DMGSEC { get; set; }
        public string DECAY { get; set; }
        public string AMMO { get; set; }
        public string COST { get; set; }
        public string MAXTT { get; set; }
        public string MARKUP { get; set; }
        public string DMGPEC { get; set; }
        public string EFF { get; set; }
        public string SIB { get; set; }
        public string SOURCE { get; set; }
        public string EFFECTS { get; set; }

        public Weapons(string _name, string _class, string _type, string _range, string _damage, string _attacks, string _dmgsec,
            string _decay, string _ammo, string _cost, string _maxtt, string _markup, string _dmgpec, string _eff, string _sib, string _source, string _effects)
        {
            NAME = _name;
            CLASS = _class;
            TYPE = _type;
            RANGE = _range;
            DAMAGE = _damage;
            ATTACKS = _attacks;
            DMGSEC = _dmgsec;
            DECAY = _decay;
            AMMO = _ammo;
            COST = _cost;
            MAXTT = _maxtt;
            MARKUP = _markup;
            DMGPEC = _dmgpec;
            EFF = _eff;
            SIB = _sib;
            SOURCE = _source;
            EFFECTS = _effects;

        }
    }

}
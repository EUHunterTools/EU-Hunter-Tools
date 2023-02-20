using System.Collections;
using System.IO;

namespace WpfApp1
{
    public class Scopes
    {
        public string NAME { get; set; }
        public string TYPE { get; set; }
        public string DAMAGE { get; set; }
        public string SKILLMOD { get; set; }
        public string SKILLBON { get; set; }
        public string ZOOM { get; set; }
        public string DECAY { get; set; }
        public string AMMO { get; set; }
        public string COST { get; set; }
        public string MAXTT { get; set; }
        public string MARKUP { get; set; }
        public string DMGPEC { get; set; }
        public string EFF { get; set; }
        public string SOURCE { get; set; }
        

        public Scopes(string _name, string _type, string _damage, string _skillmod, string _skillbon, string _zoom,
            string _decay, string _ammo, string _cost, string _maxtt, string _markup, string _dmgpec, string _eff, string _source)
        {
            NAME = _name;            
            TYPE = _type;
            DAMAGE = _damage;
            SKILLMOD = _skillmod;
            SKILLBON = _skillbon;
            ZOOM = _zoom;
            DECAY = _decay;
            AMMO = _ammo;
            COST = _cost;
            MAXTT = _maxtt;
            MARKUP = _markup;
            DMGPEC = _dmgpec;
            EFF = _eff;
            SOURCE = _source;
        }
    }

}
using System.Collections;
using System.IO;

namespace WpfApp1
{
    public class Tools
    {
        public string NAME { get; set; }
        public string TYPE { get; set; }
        public string HEAL { get; set; }
        public string EFFHEAL { get; set; }
        public string USES { get; set; }
        public string HEALSEC { get; set; }
        public string MAXTT { get; set; }
        public string MARKUP { get; set; }
        public string DECAY { get; set; }
        public string ME { get; set; }
        public string COST { get; set; }
        public string ECO { get; set; }
        public string REC { get; set; }
        public string SIB { get; set; }
        public string SOURSE { get; set; }
        public string FOUNDON { get; set; }


        public Tools(string _name, string _type, string _heal, string _effheal, string _uses, string _healsec,
            string _maxtt, string _markup, string _decay, string _me, string _cost, string _eco, string _rec, string _sib, string _sourse, string _foundon)
        {
            NAME = _name;            
            TYPE = _type;
            HEAL = _heal;
            EFFHEAL = _effheal;
            USES = _uses;
            HEALSEC = _healsec;
            MAXTT = _maxtt;
            MARKUP = _markup;
            DECAY = _decay;
            ME = _me;
            COST = _cost;
            ECO = _eco;
            REC = _rec;
            SIB = _sib;
            SOURSE = _sourse;
            FOUNDON = _foundon;
        }
    }

}
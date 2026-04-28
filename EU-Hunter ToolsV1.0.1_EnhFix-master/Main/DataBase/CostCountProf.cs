using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace WindowsFormsApp1
{
    [Serializable]
    public class CostCountProf
    {
        public double COSTUSEPROF { get; set; }

        public double SPEEDUSEPROF { get; set; }

        public int WEAPONINDEX { get; set; }

        public int AMPINDEX { get; set; }

        public int SCOPEINDEX { get; set; }

        public int LASER1INDEX { get; set; }

        public int LASER2INDEX { get; set; }

        public double RELOADNUM { get; set; }

        public int DMGENHCOUNT { get; set; }

        public bool USEEFLAG { get; set; }        //public bool UseEflag = new bool[4] { false, false, false, false };

        public int TOOLINDEX { get; set; }

        public CostCountProf(double _cost_use_prof, double _speed_use_prof, int _weapon_index, int _amp_index, int _scope_index,
            int _laser1_index, int _laser2_index, double _reload_num, int _dmg_enh_count, bool _use_e_flag, int _tool_index)
        {
            COSTUSEPROF = _cost_use_prof;
            SPEEDUSEPROF = _speed_use_prof;
            WEAPONINDEX = _weapon_index;
            AMPINDEX = _amp_index;
            SCOPEINDEX = _scope_index;
            LASER1INDEX = _laser1_index;
            LASER2INDEX = _laser2_index;
            RELOADNUM = _reload_num;
            DMGENHCOUNT = _dmg_enh_count;
            USEEFLAG = _use_e_flag;
            TOOLINDEX = _tool_index;

        }
    }
}

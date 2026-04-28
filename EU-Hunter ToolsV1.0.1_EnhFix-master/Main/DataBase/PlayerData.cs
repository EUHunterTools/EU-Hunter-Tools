using System;
using WindowsFormsApp1;
using System.Collections.Generic;
using System.Drawing;

namespace WpfApp1
{
    [Serializable]
    public class PlayerData
    {
        public bool NOMBRE { get; set; }

        public string PATH { get; set; }        

        public bool DARKMODE { get; set; }

        public bool NOHIDINGMAIN { get; set; }        

        public int OVERLAYX { get; set; }

        public int OVERLAYY { get; set; }

        public bool FLAGPROFUSE { get; set; }

        public int MOBSKILLEDPOINT { get; set; }

        public int MOBSKILLEDEVERYPOINT { get; set; }

        public int MOBSKILLEDNUMLINES { get; set; }
        
        public bool MOBSKILLEDAUTOSIZE { get; set; }

        public bool MININGMODE { get; set; }

        public bool DPSONTIME { get; set; }

        public int SBAFKTB { get; set; }

        public bool USINGE { get; set; }

        public bool OVERLAYGEAR { get; set; }

        public int OVERLAYGEARSPEED { get; set; }

        public Color DMBACKCOLOR { get; set; }

        public Color DMTEXTCOLOR { get; set; }

        public Color DMSTATCOLOR { get; set; }

        public bool LOOTAMMO { get; set; }

        public bool TEAMBACKUP { get; set; }

        public string NICKNAME { get; set; }

        public bool OUTVALUE { get; set; }

        public bool UNUSEDITEMS { get; set; }


        //public List<CostCountProf> PROFLIST { get; set; }


        public PlayerData(bool _nombre, string _path, bool _darkmode, bool _nohidingmain, int _overlay_x, int _overlay_y, bool _flag_prof_use,
            int _mobs_killed_point, int _mobs_killed_evry_point, int _mobs_killed_num_lines, bool _mobs_killed_auto_size, bool _mining_mode, bool _dps_on_time,
            int _seconds_before_afk, bool _using_e_button, bool _overlay_gear, int _overlay_gear_speed, Color _dm_back_color, Color _dm_text_color, Color _dm_stat_color, bool _loot_ammo,
            bool _team_backup, string _nickname, bool _outvalue, bool _unused_items)//List<CostCountProf> _prof_list
        {
            this.NOMBRE = _nombre;
            this.PATH = _path;            
            this.DARKMODE = _darkmode;
            this.NOHIDINGMAIN = _nohidingmain;
            //this.PROFLIST = _prof_list;
            this.OVERLAYX = _overlay_x;
            this.OVERLAYY = _overlay_y;
            FLAGPROFUSE = _flag_prof_use;
            MOBSKILLEDPOINT = _mobs_killed_point;
            MOBSKILLEDEVERYPOINT = _mobs_killed_evry_point;
            MOBSKILLEDNUMLINES = _mobs_killed_num_lines;
            MOBSKILLEDAUTOSIZE = _mobs_killed_auto_size;
            MININGMODE = _mining_mode;
            DPSONTIME = _dps_on_time;
            SBAFKTB = _seconds_before_afk;
            USINGE = _using_e_button;
            OVERLAYGEAR = _overlay_gear;
            OVERLAYGEARSPEED = _overlay_gear_speed;
            DMBACKCOLOR = _dm_back_color;
            DMTEXTCOLOR = _dm_text_color;
            DMSTATCOLOR = _dm_stat_color;
            LOOTAMMO = _loot_ammo;
            TEAMBACKUP = _team_backup;
            NICKNAME = _nickname;
            OUTVALUE = _outvalue;
            UNUSEDITEMS = _unused_items;
        }
    }
}

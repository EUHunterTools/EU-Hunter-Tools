using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{


    class GrafCounting
    {
        public int MOBSKILLED { get; set; }

        public double TT { get; set; }

        public double TTMU { get; set; }

        public double MU { get; set; }

        public GrafCounting(int _mobskilled, double _tt, double _ttmu, double _mu)
        {
            MOBSKILLED = _mobskilled;
            TT = _tt;
            TTMU = _ttmu;
            MU = _mu;
        }

    }
}

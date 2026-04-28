namespace WpfApp1
{
    public class SkillCount
    {
        public string NAME { get; set; }

        public double POINTS { get; set; }

        public int SUMMONS { get; set; }
        

        public SkillCount(string _name, double _points, int _summons)
        {            
            this.NAME = _name;
            this.POINTS = _points;
            this.SUMMONS = _summons;
        }
    }
}

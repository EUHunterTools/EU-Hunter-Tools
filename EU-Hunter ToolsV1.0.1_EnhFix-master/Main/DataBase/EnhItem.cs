namespace WpfApp1
{
    public class EnhItems
    {
        public double QUANT { get; set; }

        public string NAME { get; set; }

        public double PED { get; set; }

        public double PEDMU { get; set; }

        public double MU { get; set; }

        public EnhItems(double _cantidad, string _nombre, double _precio, double _mu)
        {
            this.QUANT = _cantidad;
            this.NAME = _nombre;
            this.PED = _precio;
            this.MU = _mu;
            this.PEDMU = QUANT * (100 / MU);
        }
    }
}

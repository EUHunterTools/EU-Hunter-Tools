namespace WpfApp1
{
  public class Items
  {
    public string NOMBRE { get; set; }

    public double CANTIDAD { get; set; }

    public double PRECIO { get; set; }

    public double MU { get; set; }

    public Items(string _nombre, double _cantidad, double _precio, double _mu)
    {
      this.NOMBRE = _nombre;
      this.CANTIDAD = _cantidad;
      this.PRECIO = _precio;
      this.MU = _mu;
    }
  }
}

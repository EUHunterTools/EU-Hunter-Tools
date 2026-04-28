namespace WpfApp1
{
  public class ItemDatabase
  {
    public int ID { get; set; }

    public string NOMBRE { get; set; }

    public double PRECIO { get; set; }

    public ItemDatabase(int _id, string _nombre, double _precio)
    {
      this.ID = _id;
      this.NOMBRE = _nombre;
      this.PRECIO = _precio;
    }
  }
}

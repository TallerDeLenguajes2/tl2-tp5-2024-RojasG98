public class Productos
{
    private int iDProductos;
    private string descripcion;
    private int precio;
    public Productos(){}

    public int IDProductos { get => iDProductos; set => iDProductos = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Precio { get => precio; set => precio = value; }
}
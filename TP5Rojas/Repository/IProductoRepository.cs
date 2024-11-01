public interface IProductoRepository
{
    Productos productoPorId(int idProducto);
    List<Productos> listarProductos();
    void CrearProducto(Productos producto);
    void eliminarProducto(int idProducto);
    void modificarProducto(int idProducto,Productos productos);
}
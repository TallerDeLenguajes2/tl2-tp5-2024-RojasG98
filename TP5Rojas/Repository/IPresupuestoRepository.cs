public interface IPresupuestoRepository
{
    Presupuestos productoPorId(int idPresupuesto);
    List<Presupuestos> listarProductos();
    void CrearProducto(Presupuestos presupuesto);
    void eliminarProducto(int idProducto);
    void modificarProducto(int idProducto,Presupuestos presupuesto);
}
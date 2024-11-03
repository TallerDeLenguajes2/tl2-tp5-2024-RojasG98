using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("[controller]")]
public class ProductoController : ControllerBase
{
    private readonly IProductoRepository repository;

    public ProductoController(IProductoRepository repository)
    {
        this.repository = repository;
    }
    [HttpPost]
    public ActionResult<List<Productos>> CrearProducto(Productos nuevoProducto){
        repository.CrearProducto(nuevoProducto);
        return Ok(repository.listarProductos());
    }
    [HttpGet]
    public ActionResult<List<Productos>> ListaProductos(){
        var lista = repository.listarProductos();
        return Ok(lista);
    }
    [HttpPut]
    public ActionResult<List<Productos>> ModificarProducto(int idProducto,string nuevoNombre){
        var producto = repository.listarProductos().Find(X => X.IDProductos == idProducto);
        var productoModificado = new Productos(producto.IDProductos,nuevoNombre,producto.Precio);
        repository.modificarProducto(idProducto,productoModificado);
        return Ok(repository.listarProductos());
    }
}
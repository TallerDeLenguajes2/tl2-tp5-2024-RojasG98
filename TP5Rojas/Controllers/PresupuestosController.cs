using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PresupuestosController : ControllerBase
{
    private IPresupuestoRepository repository;

    public PresupuestosController(IPresupuestoRepository repository)
    {
        this.repository = repository;
    }
    [HttpPost]
    public ActionResult<List<Presupuestos>> crearPresupuesto(Presupuestos nuevoPresupuesto)
    {
        repository.CrearPresupuesto(nuevoPresupuesto);
        return Ok(repository.listarPresupuestos());
    }
    [HttpPost("/TP5Rojas/Presupuesto/{idPresupuesto}/ProductoDetalle")]
    public ActionResult<List<Presupuestos>> agregarProducto(int idPresupuesto,int idProducto, int cantidad){
        repository.agregarProducto(idPresupuesto,idProducto,cantidad);
        return Ok(repository.listarPresupuestos());
    }
    [HttpGet("/TP5Rojas/Presupuesto")]
    public ActionResult<List<Presupuestos>> ListarPresupuestos(){
        return Ok(repository.listarPresupuestos());
    }
    [HttpGet("/TP5Rojas/Presupuesto/{idPresupuesto}")]
    public ActionResult<Presupuestos> presupuestoPorID(int idPresupuesto){
        return Ok(repository.presupuestoPorId(idPresupuesto));

    }

}
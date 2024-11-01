using Microsoft.Data.Sqlite;
public class ProductoRepository:IProductoRepository
{
    private string connectionString = "Data Source=dataBase/Tienda.db;Cache=Shared";
    public Productos productoPorId(int idProducto){
        SqliteConnection connection = new SqliteConnection(connectionString);
        var producto = new Productos();
        SqliteCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM dbo.Tienda WHERE idproducto = @idProducto;";
        command.Parameters.Add(new SqliteParameter("@idProducto", idProducto));
        connection.Open();
        using (SqliteDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                producto.IDProductos = Convert.ToInt32(reader["idProducto"]);
                producto.Descripcion = reader["Descripcion"].ToString();
                producto.Precio = Convert.ToInt32(reader["Precio"]);
            }
        }
        connection.Close();
        return producto;
    }
     List<Productos> listarProductos(){}
    void CrearProducto(Productos producto){}
    void eliminarProducto(int idProducto){}
    void modificarProducto(int idProducto,Productos productos){}
}
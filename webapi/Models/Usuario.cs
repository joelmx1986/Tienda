namespace webapi.Models;

public class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; } 

    public string? Apellido { get; set; }

    public int Edad { get; set; }

    public string? Correo_Electronico { get; set; }  

    public int Tipo_Usuario { get; set; }    

    public ICollection<Factura>? Facturas { get; set; }

}

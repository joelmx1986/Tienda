using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models;

public class Factura
{
    public int Id { get; set; }

    public string? Folio { get; set; }

    public float Saldo { get; set; }

    public DateTime Fecha_Facturacion { get; set; }

    public DateTime Fecha_Creacion { get; set; }

    public int Id_usuario { get; set; }

    [ForeignKey("id_usuario")]
    public Usuario? Usuario { get; set; }

    // public virtual Usuario? Usuario { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace WebApp.Data;

public class AddressEntity
{
    [Key]
    public int Id { get; set; }
    public string AdressLine_1 { get; set; } = null!;
    public string? AdressLine_2 { get; set; }
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;
}


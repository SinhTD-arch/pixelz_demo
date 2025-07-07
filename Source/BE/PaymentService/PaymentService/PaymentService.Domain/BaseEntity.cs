using System.ComponentModel.DataAnnotations;

namespace PaymentService.Domain;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
}
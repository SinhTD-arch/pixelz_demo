using System.ComponentModel.DataAnnotations;

namespace OrderService.Domain;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
}
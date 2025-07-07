using System.ComponentModel.DataAnnotations;

namespace ProductService.Domain;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
}
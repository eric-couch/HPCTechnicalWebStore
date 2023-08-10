using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HPCTechnicalWebStore.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    [Column(TypeName = "decimal(6,2)")]
    public decimal Price { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}

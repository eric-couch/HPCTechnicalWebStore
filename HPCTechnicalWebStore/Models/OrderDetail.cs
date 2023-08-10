using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HPCTechnicalWebStore.Models;

[Index(nameof(OrderId), Name = "IX_OrderDetail_OrderId")]
[Index(nameof(ProductId), Name = "IX_OrderDetail_ProductId")]
public class OrderDetail
{
    public int Id { get; set; }
    public int Qty { get; set; }
    public int ProductId { get; set; }
    public int OrderId { get; set; }

    [ForeignKey("OrderId")]
    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

}

namespace AINetCoreMVC.Models;

using System.ComponentModel.DataAnnotations;

public class OrderDetail
{
    [Key]
    public int OrderID { get; set; }
    [Key]
    public int ProductID { get; set; }
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
    public float Discount { get; set; }
}

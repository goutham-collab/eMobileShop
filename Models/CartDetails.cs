using System.ComponentModel.DataAnnotations.Schema;

namespace eMobileShop.Models;

public class CartDetails
{
    public int Id { get; set; }        
    public int ProductId { get; set; }
    
    [ForeignKey(nameof(ProductId))]
    public Product Product { get; set; }

}

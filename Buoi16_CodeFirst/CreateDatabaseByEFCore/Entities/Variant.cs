using CreateDatabaseByEFCore.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Variant : EntityBase
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }

    [DefaultValue(0)]
    public int NumberInStock { get; set; }

    [ForeignKey("Product")]
    public Guid ProductId { get; set; }

    public Product Product { get; set; }
    public ICollection<CreateDatabaseByEFCore.Entities.Attribute> Attributes { get; set; }
}

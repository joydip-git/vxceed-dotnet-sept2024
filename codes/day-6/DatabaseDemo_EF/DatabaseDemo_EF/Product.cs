using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//POCO (Plain Old CLR object)
namespace DatabaseDemo_EF
{
    [Table("products")]
    public class Product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("price")]
        public decimal? Price { get; set; }

        public override string ToString()
        {
            return $"Name={Name}, Price={Price}, Id={Id}";
        }
    }
}

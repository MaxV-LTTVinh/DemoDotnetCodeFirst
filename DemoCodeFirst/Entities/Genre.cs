using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCodeFirst.Entities
{
    [Table(name: "genres")]
    public class Genre
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public virtual List<Movie>? Movies { get; set; }
    }
}

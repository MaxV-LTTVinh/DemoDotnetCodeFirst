using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCodeFirst.Entities
{
    [Table(name: "authors")]
    public class Author
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Dob { get; set; }
        public virtual List<Movie>? Movies { get; set; }
        
    }
}

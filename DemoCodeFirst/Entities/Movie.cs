using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCodeFirst.Entities
{
    [Table(name: "movies")]
    public class Movie
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public virtual List<Genre>? Genres { get; set; }
        public Author? Author { get; set; }
    }
}

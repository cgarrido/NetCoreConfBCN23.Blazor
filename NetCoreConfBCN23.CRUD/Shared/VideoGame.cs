using System.ComponentModel.DataAnnotations;

namespace NetCoreConfBCN23.CRUD.Shared
{
    public class VideoGame
    {
        public int? Id { get; set; }

        [Required]
        [MinLength(3)]
        public string? Name { get; set; }

        [Required]
        public DateOnly Date { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
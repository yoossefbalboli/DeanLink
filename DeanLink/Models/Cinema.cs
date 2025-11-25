using System.ComponentModel.DataAnnotations;

namespace DeanLink.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }
    }
}
 
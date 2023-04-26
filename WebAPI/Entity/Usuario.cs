using System.ComponentModel.DataAnnotations;

namespace WebAPI.Entity
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; } 
        public string? Email1 { get; set;}
        public string? Alias { get; set;}
    }
}

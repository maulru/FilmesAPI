using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs
{
    public class CreateSessaoDto
    {
        [Required]
        public int FilmeId { get; set; }
    }
}

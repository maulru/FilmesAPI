using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O titulo do filme é obrigatório")]
        public String Titulo { get; set; }

        [Required(ErrorMessage = "O Gênero do filme é obrigatório")]
        [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "A duração do filme é obrigatória")]
        [Range(50, 600, ErrorMessage = "A duração deve ser entre 50 e 600 minutos")]
        public int Duracao { get; set; }
    }
}

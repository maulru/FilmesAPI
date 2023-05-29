namespace FilmesAPI.Data.DTOs
{
    public class ReadFilmeDto
    {
        public String Titulo { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
    }
}

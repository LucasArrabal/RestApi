using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O título do filme é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O genero do filme é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho do genero nao pode exceder 50 caracteres")]
        public string Genero { get; set; }
        [Required]
        [Range(70, 600, ErrorMessage = "A duraçao dever entre 70 a 600 minutos")]
        public int Duracao { get; set; }

    }
}

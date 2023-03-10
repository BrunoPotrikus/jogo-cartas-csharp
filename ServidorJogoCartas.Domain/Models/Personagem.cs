namespace ServidorJogoCartas.Domain.Models
{
    public class Personagem
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid CategoriaId { get; set; }
        public string Imagem { get; set; }
        public int Magia { get; set; }
        public int Forca { get; set; }
        public int Fogo { get; set; }
        public string Descricao { get; set; }
    }
}

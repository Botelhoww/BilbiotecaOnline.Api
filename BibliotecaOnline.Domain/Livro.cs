namespace BibliotecaOnline.Domain
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime AnoPublicacao { get; set; }
        public string Genero { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}

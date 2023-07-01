namespace BibliotecaOnline.Domain
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int IdUsuario { get; set; }
        public int IdLivro { get; set; }
        public bool IsAtrasado { get; set; }
    }
}

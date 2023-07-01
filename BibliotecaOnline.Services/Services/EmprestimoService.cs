namespace BibliotecaOnline.Domain.Services
{
    public class EmprestimoService
    {
        public static bool VerificaAtraso(DateTime dataDevolucao)
        {
            if (dataDevolucao > DateTime.Now)
                return true;

            return false;
        }
    }
}

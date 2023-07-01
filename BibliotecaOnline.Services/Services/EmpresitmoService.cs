namespace BibliotecaOnline.Domain.Services
{
    public class EmpresitmoService
    {
        public static bool VerificaAtraso(DateTime dataDevolucao)
        {
            if (dataDevolucao > DateTime.Now)
                return true;

            return false;
        }
    }
}

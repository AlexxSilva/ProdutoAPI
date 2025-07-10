namespace ProdutoAPI.Application
{
    public interface IEmailService
    {
        void Enviar(string para, string assunto, string corpo);
    }
}

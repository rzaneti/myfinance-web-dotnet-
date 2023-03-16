using myfinance_web_dotnet_.Models;

namespace myfinance_web_dotnet_.Domain.Services.Interfaces
{
    public interface ITransacaoService
    {
        List<TransacaoModel> ListarRegistros();
        void Salvar(TransacaoModel model);
        TransacaoModel RetornarRegistro(int id);
        void Excluir(int id);
    }
}

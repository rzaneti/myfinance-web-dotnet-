using myfinance_web_dotnet_.Models;

namespace myfinance_web_dotnet_.Domain.Services.Interfaces
{
    public interface IPlanoContaService
    {
        List<PlanoContaModel> ListarRegistros();
        void Salvar(PlanoContaModel model);
        PlanoContaModel RetornarRegistro(int id);
        void Excluir(int id);
    }
}
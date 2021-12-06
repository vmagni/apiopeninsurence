using Caixa.OpenInsurence.Data.Api;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Data.Interfaces
{
    public interface IDatabaseService
    {
        public Task<ProdutosPrevidenciaCompletoResponse> GetProdutosPrevidenciaCompleto();
        public Task<ProdutosVidaPfCompletoResponse> GetProdutosVidaPfCompleto();
    }
}

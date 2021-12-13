
using Caixa.OpenInsurence.Data.Models.Api;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Data.Interfaces
{
    public interface IDatabaseService
    {
        public Task<ProdutosPrevidenciaCompletoResponse> GetProdutosPrevidenciaCompleto();
        public Task<ProdutosVidaPfCompletoResponse> GetProdutosVidaPfCompleto();
        public Task<ProdutosVidaPfCompletoResponse> GetProdutosVidaPf();
        public Task<AgenciasCaixaResponse> GetAgenciasCaixa();
    }
}

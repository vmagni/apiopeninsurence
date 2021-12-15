
using Caixa.OpenInsurence.Data.Models.Api;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Data.Interfaces
{
    public interface IDatabaseService
    {
        public Task<ProdutosPrevidenciaCompletoResponse> GetProdutosPrevidenciaNovosFundos();
        public Task<ProdutosPrevidenciaCompletoResponse> GetProdutosVidaPfCompleto();
        public Task<ProdutosVidaPfCompletoResponse> GetProdutosVidaPf();
        public Task<AgenciasCaixaResponse> GetAgenciasCaixa();
        public Task<CanaisDigitaisResponse> GetCanaisDigitais();
    }
}

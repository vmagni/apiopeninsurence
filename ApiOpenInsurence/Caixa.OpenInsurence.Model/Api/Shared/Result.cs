using DocuSign.eSign.Model;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Caixa.OpenInsurence.Model.Api.Shared
{
    public sealed class Result<T> : Result where T : class
    {
        [JsonIgnore]
        public T Data { get; private set; }

        public Result()
        {
            Data = null;
        }

        public Result(T data)
        {
            Data = data;
        }

        public Result<T> AdicionarMensagemErro(string mensagem)
        {
            MensagensErro.Add(mensagem);
            return this;
        }

        public  Result<T> AdicionarMensagemErro(IEnumerable<string> mensagens)
        {
            foreach (var item in mensagens)
            {
                MensagensErro.Add(item);
            }

            return this;
        }
    }

    public class Result
    {
        public ICollection<string> MensagensErro { get; private set; }

        [JsonIgnore]
        public bool Sucesso => MensagensErro.Count == 0;

        public Result()
        {
            MensagensErro = new List<string>();
        }

        public virtual Result AdicionarMensagemErro(string mensagem)
        {
            MensagensErro.Add(mensagem);
            return this;
        }

        public virtual Result AdicionarMensagemErro(IEnumerable<string> mensagens)
        {
            foreach (var item in mensagens)
            {
                MensagensErro.Add(item);
            }

            return this;
        }

        public Result AdicionarMensagemErro(ErrorDetails errorDetails)
        {
            if (errorDetails != null)
                AdicionarMensagemErro($"{errorDetails.ErrorCode}: {errorDetails.Message}");

            return this;
        }
    }
}

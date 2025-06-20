using MenteSaudavel.Server._03.Data.ValueObjects;

namespace MenteSaudavel.Server._03.Data.Entities
{
    public class Questionario : Entity
    {
        #region PROPRIEDADES
        public Usuario Respondente { get; private set; }

        public int? Pontuacao { get; private set; }

        public Estratificacao? Estratificacao { get; private set; }

        public DateTime DataEnvio { get; private set; }

        public List<Resposta> Respostas { get; private set; } = new List<Resposta>();
        #endregion

        #region CONSTRUTORES
        internal Questionario() { }

        public Questionario(Usuario respondente, DateTime dataEnvio)
        {
            Respondente = respondente;
            DataEnvio = dataEnvio;
        }
        #endregion

        #region METODOS
        public void AdicionarResposta(Resposta resposta)
        {
            Respostas.Add(resposta);
        }

        public void CalcularPontuacao()
        {
            Pontuacao = Respostas.Count(resposta => resposta.Valor);
        }

        public void DefinirEstratificacao()
        {
            if (!Pontuacao.HasValue)
            {
                throw new ArgumentException("Pontuação deve ser calculada antes de definir a estratificação.");
            }

            Estratificacao = new Estratificacao(Pontuacao.Value);
        }
        #endregion

        #region VALIDACOES

        #endregion
    }
}

using MenteSaudavel.Server._04._Infrastructure.Enums;

namespace MenteSaudavel.Server._03.Data.Entities
{
    public class Questionario : Entity
    {
        #region PROPRIEDADES
        public Usuario Respondente { get; }

        public int Pontuacao { get; private set; }

        public EnumEstratificacao Estratificacao { get; private set; }

        public DateTime DataEnvio { get; }

        public List<Resposta> Respostas { get; } = new List<Resposta>();
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
            Estratificacao = Pontuacao switch
            {
                > 0 and <= 7 => EnumEstratificacao.Leve,
                >= 8 and <= 14 => EnumEstratificacao.Moderado,
                >= 15 and <= 20 => EnumEstratificacao.Grave,
                _ => EnumEstratificacao.NaoIdentificado
            };
        }
        #endregion

        #region VALIDACOES

        #endregion
    }
}

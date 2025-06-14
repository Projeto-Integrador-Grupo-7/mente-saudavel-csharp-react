namespace MenteSaudavel.Server._03.Data.Entities
{
    public class Resposta : Entity
    {
        public Questionario Questionario { get; }
        public int Numero { get; }
        public bool Valor { get; }

        internal Resposta() { }

        public Resposta(Questionario questionario, int numero, bool valor)
        {
            Questionario = questionario;
            Numero = numero;
            Valor = valor;
        }
    }
}
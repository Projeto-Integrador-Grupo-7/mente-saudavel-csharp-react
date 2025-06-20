namespace MenteSaudavel.Server._03.Data.Entities
{
    public class Resposta : Entity
    {
        public Questionario Questionario { get; private set; }
        public int Numero { get; private set; }
        public bool Valor { get; private set; }

        internal Resposta() { }

        public Resposta(Questionario questionario, int numero, bool valor)
        {
            Questionario = questionario;
            Numero = numero;
            Valor = valor;
        }
    }
}
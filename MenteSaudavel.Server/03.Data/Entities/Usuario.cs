namespace MenteSaudavel.Server._03.Data.Entities
{
    public class Usuario : Entity
    {
        #region PROPRIEDADES
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public DateOnly DataNascimento { get; set; }

        public char Sexo { get; set; }

        public bool IsAdmin { get; set; }

        public List<Questionario> Questionarios { get; } = new List<Questionario>();
        #endregion

        #region CONSTRUTORES
        internal Usuario() { }

        public Usuario(string nome, string email, string senha, DateOnly dataNascimento, char sexo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            IsAdmin = false;
        }
        #endregion

        #region METODOS
        public void AdicionarQuestionario(Questionario questionario)
        {
            Questionarios.Add(questionario);
        }

        public Questionario? GetUltimoQuestionario()
        {
            return Questionarios.OrderBy(questionario => questionario.DataEnvio).FirstOrDefault();
        }
        #endregion

        #region VALIDACOES

        #endregion
    }
}

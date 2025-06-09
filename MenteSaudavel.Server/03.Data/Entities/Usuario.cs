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
        #endregion

        #region CONSTRUTORES
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

        #endregion

        #region VALIDACOES

        #endregion
    }
}

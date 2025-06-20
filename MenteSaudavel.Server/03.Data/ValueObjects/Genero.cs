using MenteSaudavel.Server._04.Infrastructure.Enums;
using MenteSaudavel.Server._04.Infrastructure.Extensions;

namespace MenteSaudavel.Server._03.Data.ValueObjects
{
    public class Genero
    {
        public int Valor { get; }
        public string Descricao { get; }

        internal Genero() { }

        public Genero(int valor)
        {
            Valor = valor;

            Descricao = Valor switch
            {
                1 => EnumGenero.Feminino.GetDisplayName(),
                2 => EnumGenero.Masculino.GetDisplayName(),
                3 => EnumGenero.Outro.GetDisplayName(),
                _ => throw new ArgumentOutOfRangeException(nameof(valor), "Valor inválido para gênero.")
            };
        }

        public bool IsFeminino => Valor == EnumGenero.Feminino.GetIntValue();
        public bool IsMasculino => Valor == EnumGenero.Masculino.GetIntValue();
        public bool IsOutro => Valor == EnumGenero.Outro.GetIntValue();
    }
}

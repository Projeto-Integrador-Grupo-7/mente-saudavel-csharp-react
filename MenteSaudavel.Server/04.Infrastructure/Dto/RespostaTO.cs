using MenteSaudavel.Server._03.Data.Entities;

namespace MenteSaudavel.Server._04.Infrastructure.Dto
{
    public class RespostaTO
    {
        public Guid Id { get; set; }

        public Guid QuestionarioId { get; set; }
        
        public int Numero { get; set; }
        
        public bool Valor { get; set; }
    }
}

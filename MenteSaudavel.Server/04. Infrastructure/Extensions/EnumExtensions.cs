using System.ComponentModel.DataAnnotations;

namespace MenteSaudavel.Server._04._Infrastructure.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            var attribute = field?
                .GetCustomAttributes(typeof(DisplayAttribute), false)
                .Cast<DisplayAttribute>()
                .FirstOrDefault();

            return attribute?.Description ?? value.ToString();
        }
    }
}
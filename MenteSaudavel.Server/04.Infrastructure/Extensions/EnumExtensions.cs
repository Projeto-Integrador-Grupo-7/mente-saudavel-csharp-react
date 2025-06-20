using System.ComponentModel.DataAnnotations;

namespace MenteSaudavel.Server._04.Infrastructure.Extensions
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

        public static int GetIntValue(this Enum value)
        {
            return (int)Convert.ChangeType(value.GetType().GetField("value__").GetValue(value), typeof(int));
        }
    }
}
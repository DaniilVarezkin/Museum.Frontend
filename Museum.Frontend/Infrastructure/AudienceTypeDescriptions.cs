using Museum.Frontend.Services;

namespace Museum.Frontend.Infrastructure
{
    public static class AudienceTypeDescriptions
    {
        private static readonly Dictionary<AudienceType, string> AudienceTypeDescriptionsDictionary = new()
        {
            { AudienceType._0, "Взрослая аудитория" },
            { AudienceType._1, "Дети" },
            { AudienceType._2, "Дети до 6 лет" },
            { AudienceType._3, "Дети от 6 до 14 лет" },
            { AudienceType._4, "Пушкинская карта от 14 до 22 лет" },
            { AudienceType._5, "Семейная аудитория" }
        };

        public static string GetAudienceTypeDescription(AudienceType type)
        {
            return AudienceTypeDescriptionsDictionary.TryGetValue(type, out var description)
                ? description
                : type.ToString();
        }

        // Если enum приходит как число (byte), можно использовать:
        public static string GetAudienceTypeDescriptionFromByte(byte typeValue)
        {
            if (Enum.IsDefined(typeof(AudienceType), typeValue))
            {
                var type = (AudienceType)typeValue;
                return GetAudienceTypeDescription(type);
            }
            return typeValue.ToString(); // или какое-то значение по умолчанию
        }
    }
}

using Museum.Frontend.Services;

namespace Museum.Frontend.Infrastructure
{
    public static class AudienceTypeDescriptions
    {
        private static readonly Dictionary<AudienceType, string> AudienceTypeDescriptionsDictionary = new()
        {
            { AudienceType.Adult, "Взрослая аудитория" },
            { AudienceType.Children, "Дети" },
            { AudienceType.ChildrenUnder6, "Дети до 6 лет" },
            { AudienceType.Children6To14, "Дети от 6 до 14 лет" },
            { AudienceType.PushkinCard14To22, "Пушкинская карта от 14 до 22 лет" },
            { AudienceType.Family, "Семейная аудитория" }
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

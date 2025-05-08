using Museum.Frontend.Services;

namespace Museum.Frontend.Infrastructure
{
    public static class MuseumEventTypeDescriptions
    {
        private static readonly Dictionary<MuseumEventType, string> MuseumEventTypeDescriptionsDictionary = new()
        {
            { MuseumEventType.Promotion, "Акция" },
            { MuseumEventType.Exhibition, "Выставка" },
            { MuseumEventType.Quest, "Квест" },
            { MuseumEventType.Lecture, "Лекция" },
            { MuseumEventType.MasterClass, "Мастер-класс" },
            { MuseumEventType.MuseumActivity, "Музейное занятие" },
            { MuseumEventType.Tour, "Экскурсия" }
        };

        public static string GetMuseumEventTypeDescription(MuseumEventType type)
        {
            return MuseumEventTypeDescriptionsDictionary.TryGetValue(type, out var description)
                ? description
                : type.ToString();
        }

        // Для числового значения (byte)
        public static string GetMuseumEventTypeDescriptionFromByte(byte typeValue)
        {
            if (Enum.IsDefined(typeof(MuseumEventType), typeValue))
            {
                var type = (MuseumEventType)typeValue;
                return GetMuseumEventTypeDescription(type);
            }
            return typeValue.ToString(); // или значение по умолчанию
        }
    }
}

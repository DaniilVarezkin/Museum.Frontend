using Museum.Frontend.Services;

namespace Museum.Frontend.Infrastructure
{
    public static class MuseumEventTypeDescriptions
    {
        private static readonly Dictionary<MuseumEventType, string> MuseumEventTypeDescriptionsDictionary = new()
        {
            { MuseumEventType._0, "Акция" },
            { MuseumEventType._1, "Выставка" },
            { MuseumEventType._2, "Квест" },
            { MuseumEventType._3, "Лекция" },
            { MuseumEventType._4, "Мастер-класс" },
            { MuseumEventType._5, "Музейное занятие" },
            { MuseumEventType._6, "Экскурсия" }
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

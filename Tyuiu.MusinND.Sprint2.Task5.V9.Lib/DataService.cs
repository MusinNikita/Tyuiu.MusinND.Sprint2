using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MusinND.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int nextDay = n;
            int nextMonth = m;

            // Определение количества дней в текущем месяце
            int daysInMonth = 0;
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: // Месяцы с 31 днем
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11: // Месяцы с 30 днями
                    daysInMonth = 30;
                    break;
                case 2: // Февраль (упрощённо — 28 дней)
                    daysInMonth = 28;
                    break;
                default:
                    return "Некорректный номер месяца.";
            }

            // Увеличение дня
            if (n < daysInMonth)
            {
                nextDay = n + 1;
            }
            else
            {
                nextDay = 1; // Переход на 1-й день следующего месяца
                nextMonth = m + 1;
            }

            // Возвращаем строку в формате "дд.мм", но если n < 10 или m < 10, добавляем нули впереди
            return $"{nextDay:D2}.{nextMonth:D2}";
        }
    }
}
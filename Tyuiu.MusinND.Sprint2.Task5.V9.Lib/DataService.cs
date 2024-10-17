﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MusinND.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int nextDay = n;
            int nextMonth = m;

            // Определение количества дней в месяце через switch
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
                case 2: // Февраль (для простоты — 28 дней)
                    daysInMonth = 28;
                    break;
                default:
                    return "Некорректный номер месяца.";
            }

            // Вычисление следующего дня
            if (n < daysInMonth)
            {
                nextDay = n + 1;
            }
            else
            {
                nextDay = 1;
                nextMonth = m + 1;
            }

            // Проверка выхода за пределы 12 месяцев
            if (nextMonth > 12)
            {
                nextMonth = 1;
            }

            // Возвращаем строку в формате "дд.мм" с ведущими нулями
            return $"{nextDay:D2}.{nextMonth:D2}";
        }
    }
}
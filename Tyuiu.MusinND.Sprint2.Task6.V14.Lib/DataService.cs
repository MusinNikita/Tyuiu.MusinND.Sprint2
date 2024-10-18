﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MusinND.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            int shift = (k - 1) % 7;

            int dayOfWeek = (d + shift - 1) % 7 + 1;

            switch (dayOfWeek)
            {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 7:
                    return "Воскресенье";
                default:
                    return "Ошибка";
            }
        }
        
    }
}
